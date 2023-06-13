using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsprogramday2
{
    public class PhotoAlbum
    {
        private int numberOfPages;

        public PhotoAlbum()
        {
            numberOfPages = 16;
        }

        public PhotoAlbum(int pages)
        {
            numberOfPages = pages;
        }

        public int GetNumberOfPages()
        {
            return numberOfPages;
        }
    }
}
