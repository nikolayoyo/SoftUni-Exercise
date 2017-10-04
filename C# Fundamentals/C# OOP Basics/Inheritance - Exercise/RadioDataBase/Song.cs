using System;

public class Song
{
    private string title;
    private int[] duration;
    private string singer;

    public Song(string singer, string title, int[] duration)
    {
        this.Singer = singer;
        this.Title = title;
        this.Durantion = duration;
    }
    public string Singer
    {
        get { return this.singer; }
        set
        {
            this.VadlidateNames(value, "Artist name should be between 3 and 20 symbols.");

            this.singer = value;
        }
    }

    public int[] Durantion
    {
        get { return this.duration; }
        set
        {
            if (value[0]>14 || value[0]<0)
            {
                throw new ArgumentException("Song minutes should be between 0 and 14.");
            }

            if (value[1]<0 || value[1]>59)
            {
                throw new ArgumentException("Song seconds should be between 0 and 59.");
            }

            this.duration = value;
        }
    }

    public string Title
    {
        get { return this.title; }
        set
        {
            this.VadlidateNames(value, "Song name should be between 3 and 30 symbols.");
            this.title = value;
        }        
    }

    private void VadlidateNames(string name, string exception)
    {
        if (name.Length<3 || name.Length>20)
        {
            throw new ArgumentException(exception);
        }
    }
}

