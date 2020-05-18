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
        public UserGenerator(String username, String password) {
            userTemp = new UserTemplate();
            userTemp.username = username;
            userTemp.password = password;
        }

        public void generate() {
            //userTemp.avatar_url = randomAvatar();
            userTemp.statistics = generateStatistics();
        }

        // Grabs a random avatar from the assets and returns it
        private String randomAvatar() {
            var rand = new Random();
            var files = Directory.GetFiles("../assets/images/avatars/", "*.png");
            return files[rand.Next(files.Length)];
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
