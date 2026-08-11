using System;
using System.Collections.Generic;
using System.Text;


namespace ObjectOrientationClass.Polymorphism
{
    internal class Animal
    {
        protected void PlaySound(string filename)
        {
            string fileNamePath = $"./Polymorphism/sounds/{filename}.mp3";

            using (var audioFile = new NAudio.Wave.AudioFileReader(fileNamePath))
            using (var outputDevice = new NAudio.Wave.WaveOutEvent())
            {
                outputDevice.Init(audioFile);
                outputDevice.Play();

                while (outputDevice.PlaybackState == NAudio.Wave.PlaybackState.Playing)
                {
                    Thread.Sleep(1000);
                }
            }
        }


        public virtual void MakeNoise()
        {
            Console.WriteLine("All animals can make a noise");
        }
    }
}
    

