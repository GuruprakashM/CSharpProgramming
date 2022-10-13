using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieBooking
{
    /* MovieID (MID1001)  MovieName
 Language*/
    public class MovieDetails
    {
        /// <summary>
        /// Unqiue ID of Movie
        /// </summary>
        private static int s_movieId=500;
         /// <summary>
        /// Unqiue ID of Movie
        /// </summary>

        public string MovieID { get; set; }

        /// <summary>
        /// Movie name
        /// </summary>
        /// <value></value>
        public string MovieName { get; set; }
        /// <summary>
        /// Name Of Language Of Movies
        /// </summary>
        /// <value></value>
        public string  Language { get; set; }
        /// <summary>
        /// MovieDetails Showing Process
        /// </summary>
        /// <param name="movieName"></param>
        /// <param name="language"></param>
        public MovieDetails(string movieName, string language)
        {
             s_movieId++;
             MovieID="MID"+s_movieId;
             MovieName=movieName;
             Language=language;
        }
        /// <summary>
        /// MovieDetails ReadFile Concept
        /// </summary>
        /// <param name="data"></param>
        public MovieDetails(string data)
        {
           string[] values= data.Split(",");
           s_movieId = int.Parse(values[0].Remove(0,3));
           MovieID=values[0];
           MovieName = values[1];
           Language=values[2];
          
        }
        

    }
}