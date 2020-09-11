using MyBackEndProject_Asp.Net_Core_3._1_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBackEndProject_Asp.Net_Core_3._1_.ViewModels
{
    public class HomeVm
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<NoticeBoard> NoticeBoards { get; set; }
        public IEnumerable<NoticeProfession> NoticeProfessions { get; set; }
        public EudoHomeChoose EudoHomeChooses { get; set; }
        public Testimonial Testimonials { get; set; }
    }
}
