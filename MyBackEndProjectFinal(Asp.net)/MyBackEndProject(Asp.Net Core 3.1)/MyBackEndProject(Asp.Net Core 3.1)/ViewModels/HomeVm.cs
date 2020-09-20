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
        public IEnumerable<NoticeProfession> NoticeProfessions { get; set; }
        public EudoHomeChoose EudoHomeChooses { get; set; }

        public WelcomeEduHome welcomeEduHome { get; set; }
        public TakeVideo TakeVideo { get; set; }
        public IEnumerable<NewEvent> NewEvents {get;set;}
        public IEnumerable<Logo> logos { get; set; }
    }
}
