using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Oops
{
    class Movie
    { 
        string moviname;
        string directorname;
        string producer;
        string actorname;
        string rating;

    public void setMoviename(string mname)
    {
        moviname = mname;
    }
    public string getMoviename()
    {
        return moviname;
    }

    public void setDirectorname(string dname)
    {
        directorname = dname;
    }
    public string getDirectorname()
    {
        return directorname;
    }

    public void setProducer(string pname)
    {
        producer = pname;
    }
    public string getProducer()
    {
        return producer;
    }
    public void setActor(string aname)
    {
        actorname = aname;
    }
    public string getActor()
    {
        return actorname;
    }

    public void setRating(string rate)
    {
        rating = rate;
    }
    public string getRating()
    {
        return rating;
    }
      /*  public string MovieRating()
        {
            if (rating >= 3.5)
                return "super Hit";
            else if (rating >= 2.5)
                return "Hit";
            else
                return "Flop";
        }
      */
    static void Main(string[] args)
    {
        Movie m = new Movie();
        Console.WriteLine("Enter The Moviename");
        string mn = Console.ReadLine();
        m.setMoviename(mn);

        Console.WriteLine("Enter The Directorname");
        string dn = Console.ReadLine();
        m.setDirectorname(dn);

        Console.WriteLine("Enter The Producer");
        string pn = Console.ReadLine();
        m.setProducer(pn);

        Console.WriteLine("Enter The ActorName");
        string an = Console.ReadLine();
        m.setActor(an);

        Console.WriteLine("Enter The Rating");
        string ratee = (Console.ReadLine());
        m.setRating(ratee);


            Console.WriteLine(":::Movie Details :::");
            Console.WriteLine(m.getMoviename());
            Console.WriteLine(m.getDirectorname());
            Console.WriteLine(m.getProducer());
            Console.WriteLine(m.getActor());
            Console.WriteLine(m.getRating());


        }

    }
}
