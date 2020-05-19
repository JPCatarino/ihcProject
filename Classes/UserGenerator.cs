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

        public void generate() {
            userTemp.avatar_url = randomAvatar();
            userTemp.statistics = generateStatistics();
        }

        // Grabs a random avatar from the assets and returns it
        // TODO Fix path error
        private String randomAvatar() {
            var rand = new Random();
            string[] gender = {"boy", "girl"};

            // C# doesn't let you pick a random resource so I had to this mess.
            return "../assets/images/avatars/" + gender[rand.Next(gender.Length)] + "-" + rand.Next(0 ,8) + ".png";
        }

        private Statistics generateStatistics() {
            Statistics ret = new Statistics();
            var rand = new Random();

            // Generate Level
            ret.level = new Level();
            ret.level.current = rand.Next(100);

            // Generate pp
            ret.pp = rand.Next(19321);

            // Generate Rank
            // TODO make this aware of other users.
            ret.rank = new Rank();
            ret.rank.global = rand.Next(1000);
            ret.rank.country = rand.Next((int)ret.rank.global);

            return ret;
        }

        public UserTemplate getUser() {
            return this.userTemp;
        }
    }
}
