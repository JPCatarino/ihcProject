using ihcProject.Pages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ihcProject.Classes
{
    class UserGenerator
    {
        UserTemplate userTemp;
        public UserGenerator(String username, String password, String role) {
            userTemp = new UserTemplate();
            userTemp.username = username;
            userTemp.password = password;
            userTemp.role = role;
        }

        // TODO implement more generating as needed
        public void generate() {
            userTemp.avatar_url = randomAvatar();
            userTemp.statistics = generateStatistics();
            userTemp.weekly_playcount = generatePlaycounts();
            userTemp.profile_choices = initProfile();
        }

        // Grabs a random avatar from the assets and returns it
        // TODO Fix path error
        private String randomAvatar() {
            var rand = new Random();
            string[] gender = {"boy", "girl"};

            // C# doesn't let you pick a random resource so I had to this mess.
            return "../assets/images/avatars/" + gender[rand.Next(gender.Length)] + "-" + rand.Next(0 ,8) + ".png";
        }

        private Profile_Choices initProfile() {
            Profile_Choices temp = new Profile_Choices();
            temp.cb1_item = -1;
            temp.cb2_item = -1;
            temp.cb3_item = -1;
            temp.cb4_item = -1;
            return temp;

        }

        private Statistics generateStatistics() {
            Statistics ret = new Statistics();
            var rand = new Random();

            // Generate Level
            ret.level = new Level();
            ret.level.current = rand.Next(100);

            // Generate pp
            ret.pp = rand.Next(19321);
            ret.pp_change = rand.Next(-200, 200);

            // Generate Rank
            // TODO make this aware of other users.
            ret.rank = new Rank();
            ret.rank.global = rand.Next(1000);
            ret.rank.country = rand.Next((int)ret.rank.global);
            ret.rank.rank_change = rand.Next(-20, 20);

            return ret;
        }

        private Weekly_Playcount generatePlaycounts() {
            Weekly_Playcount ret = new Weekly_Playcount();
            Random random = new Random();

            ret.count_standard = random.Next(100);
            ret.count_mania = random.Next(100);
            ret.count_ctb = random.Next(100);
            ret.count_taiko = random.Next(100);
            ret.total_count = ret.count_standard + ret.count_mania + ret.count_ctb + ret.count_taiko;

            return ret;
        }

        public UserTemplate getUser() {
            return this.userTemp;
        }
    }
}
