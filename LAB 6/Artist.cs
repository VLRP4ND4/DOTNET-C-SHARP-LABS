using System.Collections.Generic;

namespace LAB_6
{
    public class Artist
    {
        public string Name { get; set; }
        public string Bio { get; set; }
        public List<string> ImagePaths { get; set; }

        public Artist(string name, string bio, List<string> imagePaths)
        {
            Name = name;
            Bio = bio;
            ImagePaths = imagePaths;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}