using System;
using Sony.Vegas;

public class EntryPoint
{
	public void FromVegas(Vegas vegas)
	{
		foreach (Track track in vegas.Project.Tracks)
		{
			if (track.IsVideo())
			{
				foreach (TrackEvent evnt in track.Events)
				{
					VideoEvent videoEvent = (VideoEvent) evnt;
					videoEvent.ResampleMode = VideoResampleMode.Disable;
				}
			}
		}
	}
}