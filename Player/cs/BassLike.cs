using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Un4seen.Bass;



namespace Player.cs
{

	public static class BassLike
	{

		public static int HZ = 44100;

		public static bool InitDefaultDevice;

		public static int Stream;

		public static int voulme = 100;

		//private static bool BASS_Init(int v, int hz, BASSInit BASS_DEVICE_DEFAULT, IntPtr zero)
		//{
		//	throw new NotImplementedException();
		//}

		private static bool InitBass(int hz)
		{

			if (!InitDefaultDevice)
			{

				InitDefaultDevice = Bass.BASS_Init(-1, hz, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);

			}

			return InitDefaultDevice;
		}


		public static void Stop()
		{

			Bass.BASS_ChannelStop(Stream);
			Bass.BASS_StreamFree(Stream);

		}

		public static void PlayNew(string filename, int vol)
		{
			if (InitBass(HZ))
			{
				Stream = Bass.BASS_StreamCreateFile(filename, 0, 0, BASSFlag.BASS_DEFAULT);

				if (Stream != 0)
				{
					Bass.BASS_ChannelSetAttribute(Stream, BASSAttribute.BASS_ATTRIB_VOL, voulme / 100F);
					Bass.BASS_ChannelPlay(Stream, false);
				}
			}
		}

			public static void Play(string filename, int vol)
		{
			
			if (InitBass(HZ))
			{
				if (Stream == 0)
				{
					Stream = Bass.BASS_StreamCreateFile(filename, 0, 0, BASSFlag.BASS_DEFAULT);
					
				}
				else
				{
					Bass.BASS_ChannelPlay(Stream, false);
				}
				if (Stream != 0)
				{
					Bass.BASS_ChannelSetAttribute(Stream, BASSAttribute.BASS_ATTRIB_VOL, voulme / 100F);
					Bass.BASS_ChannelPlay(Stream, false);
				}
			}
			/*
			if (InitBass(HZ))
			{
				if (Stream == 0)
				{
					Stream = Bass.BASS_StreamCreateFile(filename, 0, 0, BASSFlag.BASS_DEFAULT);
				}
				else
				{
					Bass.BASS_ChannelPlay(Stream, false);
				}
				if (Stream != 0)
				{
					Bass.BASS_ChannelSetAttribute(Stream, BASSAttribute.BASS_ATTRIB_VOL, voulme / 100F);
					Bass.BASS_ChannelPlay(Stream, false);
				}
			}
			*/
		}


		public static int GetTimeOfStream(int stream)
		{
			long TimeBytes = Bass.BASS_ChannelGetLength(stream);
			double Time = Bass.BASS_ChannelBytes2Seconds(stream, TimeBytes);
			return (int)Time;
		}

		public static int GetPosOfStream(int stream)
		{
			long pos = Bass.BASS_ChannelGetPosition(stream);
			int posSec = (int)Bass.BASS_ChannelBytes2Seconds(stream, pos);
			return posSec;

		}

		public static void SetVoulmeToStream(int stream, int vol)
		{
			voulme = vol;
			Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, voulme / 100F);
			
		}

		public static void SetPosOfScroll(int stream, int pos)
		{
			Bass.BASS_ChannelSetPosition(stream, (double)pos);

		}

		public static void Pause()
		{
			Bass.BASS_ChannelPause(Stream);
		}

	




	}
}

