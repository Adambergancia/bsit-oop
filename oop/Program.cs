﻿using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

    }
}

//Encapsulation
abstract class Webtoon
{
    //private
    private string genre;
    private string title;
    private string author;
    private string description;
    private string updateDay;
    private int episode;

    //public
    public string Genre
    {
        get => genre; 
        set => genre = value;
    }
    public string Title
    {
        get => title; 
        set => title = value;
    }
    public string Author
    {
        get => author; 
        set => author = value;
    }
    public string Description
    {
        get => description; 
        set => description = value;
    }
    public string UpdateDay
    {
        get => updateDay;
        set => updateDay = value;
    }
    public int Episode
    {
        get => episode; 
        set => episode = value;
    }

    //Abstraction
    public abstract void displaySeries();
    public abstract void displayCurrentEpisode();
    public abstract void displayNextEpisode();

    //Constructor
    public Webtoon(string genre, string title, string author, 
        string description, string updateDay, int episode)
    {
        Genre = genre;
        Title = title;
        Author = author;
        Description = description;
        Episode = episode;
    }

    public void displayRomanceSeries()
    {
        Console.WriteLine("Genre: " + Genre);
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author/s: " + Author);
        Console.WriteLine("Description: " + Description);
        Console.WriteLine("Updates every: " + UpdateDay);
    }
    public void displayComedySeries()
    {
        Console.WriteLine("Genre: " + Genre);
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author/s: " + Author);
        Console.WriteLine("Description: " + Description);
        Console.WriteLine("Updates every: " + UpdateDay);
    }
    public void displayThrillerSeries()
    {
        Console.WriteLine("Genre: " + Genre);
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author/s: " + Author);
        Console.WriteLine("Description: " + Description);
        Console.WriteLine("Updates every: " + UpdateDay);
    }
    public void displayFantasySeries()
    {
        Console.WriteLine("Genre: " + Genre);
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author/s: " + Author);
        Console.WriteLine("Description: " + Description);
        Console.WriteLine("Updates every: " + UpdateDay);
    }
}

//Inheritance
class RomanceSeries : Webtoon
{
    public RomanceSeries (string genre, string title, string author,
        string description, string updateDay, int episode)
    {

    }
    public override void displaySeries()
    {
        Console.WriteLine("Genre: " + Genre);
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author/s: " + Author);
        Console.WriteLine("Updates every: " + UpdateDay);
    }
    public override void displayCurrentEpisode()
    {
        Console.WriteLine("Episode " + Episode);
    }
    public override void displayNextEpisode()
    {
        Console.WriteLine("Episode " + Episode);
    }
}

//Inheritance2
class ComedySeries : Webtoon
{
    public ComedySeries(string genre, string title, string author,
        string description, string updateDay, int episode)
    {

    }
    public override void displaySeries()
    {
        Console.WriteLine("Genre: " + Genre);
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author/s: " + Author);
        Console.WriteLine("Updates every: " + UpdateDay);
    }
    public override void displayCurrentEpisode()
    {
        Console.WriteLine("Episode " + Episode);
    }
    public override void displayNextEpisode()
    {
        Console.WriteLine("Episode " + Episode);
    }
}
//Inheritance3
class ThrillerSeries : Webtoon
{
    public ThrillerSeries(string genre, string title, string author,
        string description, string updateDay, int episode)
    {

    }
    public override void displaySeries()
    {
        Console.WriteLine("Genre: " + Genre);
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author/s: " + Author);
        Console.WriteLine("Updates every: " + UpdateDay);
    }
    public override void displayCurrentEpisode()
    {
        Console.WriteLine("Episode " + Episode);
    }
    public override void displayNextEpisode()
    {
        Console.WriteLine("Episode " + Episode);
    }
}
//Inheritance4
class FantasySeries : Webtoon
{
    public FantasySeries(string genre, string title, string author,
        string description, string updateDay, int episode)
    {

    }
    public override void displaySeries()
    {
        Console.WriteLine("Genre: " + Genre);
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author/s: " + Author);
        Console.WriteLine("Updates every: " + UpdateDay);
    }
    public override void displayCurrentEpisode()
    {
        Console.WriteLine("Episode " + Episode);
    }
    public override void displayNextEpisode()
    {
        Console.WriteLine("Episode " + Episode);
    }
}
