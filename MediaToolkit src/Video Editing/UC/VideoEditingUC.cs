using MediaToolkit;
using MediaToolkit.Model;
using MediaToolkit.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Video_Editing.UC
{
    public partial class VideoEditingUC : UserControl
    {
        private List<FrameInfo> AllFrames;
        public VideoEditingUC()
        {
            InitializeComponent();
            AllFrames = new List<FrameInfo>();
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            
            string outputPath = Path.ChangeExtension(txtFilePath.Text, "mp3");
            var result = Convert(txtFilePath.Text,outputPath);
            AppendLineToTextBox("First step of converting from mpeg to mp3 done");
            if (result)
            {
                var mp4WithBackground=Path.ChangeExtension(outputPath, "mp4");
                result =SetBackgroundColorToMp3(outputPath, mp4WithBackground);
                AppendLineToTextBox("Step two completed");
                if (result)
                {
                    result = SetOverlayImagesToVideo(mp4WithBackground, AllFrames);
                    AppendLineToTextBox("Step three completed");
                    if (result)
                    {
                        MessageBox.Show("Successfully completed all steps");
                    }
                    else
                    {
                        MessageBox.Show("Converted to mp4 with white background");
                    }
                }
                else
                {
                    MessageBox.Show("Converted to mp3 but not to mp4");
                }
            }
            else
                MessageBox.Show("Process Ended without success");
        }
        private bool Convert(string inputFilePath, string outputFilePath)
        {
            var inputFile = new MediaFile { Filename = inputFilePath };
            var outputFile = new MediaFile { Filename = outputFilePath };
            var conversionOptions = new ConversionOptions
            {
                VideoAspectRatio = VideoAspectRatio.R16_9,
                VideoSize = VideoSize.Hd1080,
                AudioSampleRate = AudioSampleRate.Hz44100
            };
            try
            {
                using (var engine = new Engine())
                {
                    engine.Convert(inputFile, outputFile, conversionOptions);

                }
                return true;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error:", exp.Message);
                return false;
            }

        }
        private bool SetBackgroundColorToMp3(string inputFilePath,string outputFilePath,string color = "white")
        {
            var command= $"-i \"{inputFilePath}\" -f lavfi -i color=c={color}:s=1920x1080:r=15 -acodec copy -shortest \"{outputFilePath}\"";
            try {
                ExecuteCommand(command);
                return true;
            }
            catch(Exception exp)
            {
                return false;
            }
        }
        private bool SetOverlayImagesToVideo(string inputFilePath, List<FrameInfo> frames)
        {
            //var command = "-y -i input.mp4 -i 1.png -i 2.png -filter_complex [0][1]overlay=enable='between(t,5,35)':x=10:y=10[out];[out][2]overlay=enable='between(t,40,55)':x=10:y=20[out] -map [out] -map 0:a? output.mp4 2> Overlay.txt";
            var command = BuildCommand(inputFilePath,frames);
            try
            {
                ExecuteCommand(command);
                return true;
            }
            catch (Exception exp)
            {
                return false;
            }
        }
        private string BuildCommand(string inputFilePath, List<FrameInfo> frames)
        {
            string result = string.Empty;

            var inputs = $"-i \"{inputFilePath}\" ";
            inputs = inputs+string.Join(" ", frames.Select(x => "-i \""+x.FrameImage+"\"").ToArray());
            var frameConfigs = frames.Select((item, i) => 
            {
                if (i == 0)
                {
                    return $"[0][1]overlay=enable='between(t,{item.StartTime},{item.EndTime})':x=1:y=1[out];";
                }
                return $"[out][{(i+1)}]overlay=enable='between(t,{item.StartTime},{item.EndTime})':x=1:y=2[out];";
            }).ToArray();
            var frameConfig = string.Join("", frameConfigs);
            frameConfig = frameConfig.TrimEnd(';');
            var outputPath= Path.Combine(Path.GetDirectoryName(inputFilePath),"New-" + Path.GetFileName(inputFilePath));
            result = $"-y {inputs} -filter_complex {frameConfig} -map [out] -map 0:a? \"{outputPath}\"";

            return result;
        }
        private bool ExecuteCommand(string command)
        {
            
            using(var engine =new Engine())
            {
                try
                {
                    engine.CustomCommand(command);
                }catch(Exception)
                {
                    return false;
                }
            }
            return true;
        }
//        private void ExecuteProcess(string command)
//        {

//            using (var process = Process.Start(command))
//            {
//                Exception caughtException = null;
//                if (process == null)
//                {
//                    throw new InvalidOperationException("Exceptions_FFmpeg_Process_Not_Running");
//                }

//                process.ErrorDataReceived += (sender, received) =>
//                {
//                    if (received.Data == null) return;
//#if (DebugToConsole)
//                    Console.WriteLine(received.Data);
//#endif
//                    try
//                    {

//                        //receivedMessagesLog.Insert(0, received.Data);
//                        //if (engineParameters.InputFile != null)
//                        //{
//                        //    RegexEngine.TestVideo(received.Data, engineParameters);
//                        //    RegexEngine.TestAudio(received.Data, engineParameters);

//                        //    Match matchDuration = RegexEngine.Index[RegexEngine.Find.Duration].Match(received.Data);
//                        //    if (matchDuration.Success)
//                        //    {
//                        //        if (engineParameters.InputFile.Metadata == null)
//                        //        {
//                        //            engineParameters.InputFile.Metadata = new Metadata();
//                        //        }

//                        //        TimeSpan.TryParse(matchDuration.Groups[1].Value, out totalMediaDuration);
//                        //        engineParameters.InputFile.Metadata.Duration = totalMediaDuration;
//                        //    }
//                        //}
//                        ConversionCompleteEventArgs convertCompleteEvent;
//                        ConvertProgressEventArgs progressEvent;

//                        //if (RegexEngine.IsProgressData(received.Data, out progressEvent))
//                        //{
//                        //    progressEvent.TotalDuration = totalMediaDuration;
//                        //    this.OnProgressChanged(progressEvent);
//                        //}
//                        //else if (RegexEngine.IsConvertCompleteData(received.Data, out convertCompleteEvent))
//                        //{
//                        //    convertCompleteEvent.TotalDuration = totalMediaDuration;
//                        //    this.OnConversionComplete(convertCompleteEvent);
//                        //}
//                    }
//                    catch (Exception ex)
//                    {
//                        // catch the exception and kill the process since we're in a faulted state
//                        caughtException = ex;

//                        try
//                        {
//                            process.Kill();
//                        }
//                        catch (InvalidOperationException)
//                        {
//                            // swallow exceptions that are thrown when killing the process, 
//                            // one possible candidate is the application ending naturally before we get a chance to kill it
//                        }
//                    }
//                };

//                process.BeginErrorReadLine();
//                process.WaitForExit();

//                if ((process.ExitCode != 0 && process.ExitCode != 1) || caughtException != null)
//                {
//                    throw new Exception(
//                        process.ExitCode + ": " ,//+ receivedMessagesLog[1] + receivedMessagesLog[0],
//                        caughtException);
//                }
//            }

//        }
        private void BasicConversion(string inputFilePath, string outputFilePath)
        {
            var inputFile = new MediaFile { Filename = inputFilePath };
            var outputFile = new MediaFile { Filename = outputFilePath };

            using (var engine = new Engine())
            {
                engine.Convert(inputFile, outputFile);
            }
        }
        private string MetaData(string inputFilePath)
        {
            var inputFile = new MediaFile { Filename = inputFilePath };

            using (var engine = new Engine())
            {
                engine.GetMetadata(inputFile);

            }

            return JsonConvert.SerializeObject(inputFile.Metadata);
        }
        private void Cutter(string inputFilePath, string outputFilePath)
        {
            var inputFile = new MediaFile { Filename = inputFilePath };
            var outputFile = new MediaFile { Filename = outputFilePath };

            using (var engine = new Engine())
            {
                engine.GetMetadata(inputFile);

                var options = new ConversionOptions();

                // This example will create a 25 second video, starting from the 
                // 30th second of the original video.
                //// First parameter requests the starting frame to cut the media from.
                //// Second parameter requests how long to cut the video.
                options.CutMedia(TimeSpan.FromSeconds(30), TimeSpan.FromSeconds(25));

                engine.Convert(inputFile, outputFile, options);
            }
        }

        private void btnBrowseInputFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Audio Files|*.mpeg;*.mp3;";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog1.FileName;
            }
        }

        private void btnBrowseImageFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtImageFilePath.Text = openFileDialog1.FileName;
            }
        }

        private void btnAddFrame_Click(object sender, EventArgs e)
        {
            if (txtImageFilePath.Text == string.Empty)
            {
                MessageBox.Show("Please select input file");
                return;
            }

            var frame = new FrameInfo((int)(numStartHH.Value*60*60+numStartMM.Value*60+numStartSS.Value),
                (int)(numEndHH.Value * 60 * 60 + numEndMM.Value * 60 + numEndSS.Value),
                txtImageFilePath.Text);

            AllFrames.Add(frame);
            AppendLineToTextBox(frame.ToString());
        }
        private void AppendLineToTextBox(string message)
        {
            txtAllFramesInfo.Text += Environment.NewLine +message ;
        }
        private int GetTotalSeconds(DateTimePicker dtp)
        {
            return dtp.Value.Second + dtp.Value.Minute * 60 + dtp.Value.Hour * 60 * 60;
        }
    }
    public class FrameInfo
    {
        public FrameInfo(int startTime,int endTime,string frameImage)
        {
            StartTime = startTime;
            EndTime = endTime;
            FrameImage = frameImage;
        }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
        public string FrameImage { get; set; }
        public string FrameText { get; set; }
        public override string ToString()
        {
            return $"{StartTime},{EndTime},{FrameImage}";
        }
    }
}
