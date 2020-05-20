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
            get { return new Uri("pack://application:,,,/assets/images/icons/ranks/ranking-S.png"); }
        }

        public Uri StaticBeatmapImage
        {
            get { return new Uri("pack://application:,,,/assets/images/beatmaps/4.jpg"); }
        }

        public String StaticBeatmapName
        {
            get { return "Test Beatmap"; }
        }

        public Uri StaticGameModeIcon
        {
            get { return new Uri("pack://application:,,,/assets/images/icons/game_modes/mode-taiko.png"); }
        }

        public int StaticBeatmapPercentage
        {
            get { return 98; }
        }

        public int StaticBeatmapPP
        {
            get { return 132; }
        }
    }

    
}
