using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ihcProject.Data
{
    class staticBeatmapRecData
    {
        public Uri StaticRankIcon
        {
            get {
                string[] rank = { "A", "B", "C", "D", "S", "SH", "X", "XH" };
                Random random = new Random();
                string r = rank[random.Next(0, 8)];
                return new Uri("pack://application:,,,/assets/images/icons/ranks/ranking-"+ r + ".png"); }
        }

        public Uri StaticBeatmapImage
        {
            get {
                Random random = new Random();
                return new Uri("pack://application:,,,/assets/images/beatmaps/"+ random.Next(1,11).ToString() +".jpg"); }
        }

        public String StaticBeatmapName
        {
            get {
                Random random = new Random();
                string[] btn = { "Rubber Band", "anticrystal", "Akari no Arika", "WANNABE", "Mare Maris", "Dramatic Star", "Dream Catcher", "eastward", "CHAIN", "veil", "A Garagem da Vizinha" };
                return btn[random.Next(0,11)]; }
        }

        public Uri StaticGameModeIcon
        {
            get {
                Random random = new Random();
                string[] md = { "osu", "mania", "fruits", "taiko"};
                return new Uri("pack://application:,,,/assets/images/icons/game_modes/mode-" + md[random.Next(0,4)]  + ".png"); }
        }

        public int StaticBeatmapPercentage
        {
            get {
                Random random = new Random();
                return random.Next(80,101); }
        }

        public int StaticBeatmapPP
        {
            get {
                Random random = new Random();
                return random.Next(50, 400);
            }
        }
    }

    
}
