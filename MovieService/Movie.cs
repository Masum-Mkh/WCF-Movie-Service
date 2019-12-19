using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MovieService
{
    [DataContract]
    public  class Movie
    {
        [Key]
        [DataMember(Order =0)]
        public int Id { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Director { get; set; }
        [DataMember]
        public float Duration { get; set; }
        [DataMember]
        public DateTimeOffset? RealeaseDate { get; set; } = DateTimeOffset.Now;
    }
    public class MovieContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public MovieContext() : base()
        {

        }
    }
}
