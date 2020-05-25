using ihcProject.Pages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

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
            userTemp.profile_choices = initProfileChoices();
            userTemp.profile_specs = initProfileSpecs();
            userTemp.country = generateCountry();
        }

        public void generateRival()
        {
            userTemp.avatar_url = randomAvatar();
            userTemp.statistics = generateStatistics();
            userTemp.weekly_playcount = generatePlaycounts();
            userTemp.profile_choices = initRandomProfileChoices();
            userTemp.profile_specs = initProfileSpecs();
            userTemp.country = generateCountry();
        }

        // Grabs a random avatar from the assets and returns it
        // TODO Fix path error
        private String randomAvatar() {
            var rand = new Random();
            string[] gender = {"boy", "girl"};

            // C# doesn't let you pick a random resource so I had to this mess.
            return "../assets/images/avatars/" + gender[rand.Next(gender.Length)] + "-" + rand.Next(0 ,8) + ".png";
        }

        private Profile_Choices initProfileChoices() {
            Profile_Choices temp = new Profile_Choices();
            temp.cb1_item = 0;
            temp.cb2_item = 0;
            temp.cb3_item = 0;
            temp.cb4_item = 0;
            temp.pss_item = 0;
            return temp;
        }

        private Profile_Choices initRandomProfileChoices()
        {
            Profile_Choices temp = new Profile_Choices();
            Random random = new Random();
            temp.cb1_item = random.Next(0 ,4);
            temp.cb2_item = random.Next(0, 4); 
            temp.cb3_item = random.Next(0, 4);
            temp.cb4_item = random.Next(0, 4);
            temp.pss_item = random.Next(1, 3);
            return temp;

        }

        private profile_specs initProfileSpecs() {
            profile_specs temp = new profile_specs();
            Random random = new Random();
            temp.star = random.Next(1, 10);
            temp.speed = random.Next(1, 10);
            temp.ad = random.Next(1, 10);
            temp.avgBeatmapTime = random.Next(0, 10).ToString("D2") + ":" + random.Next(0, 59).ToString("D2");
            temp.avgBPM = random.Next(100, 350);
            temp.cs = random.Next(1, 10);
            temp.ar = random.Next(1, 10);
            temp.od = random.Next(1, 10);
            temp.hp = random.Next(1, 10);
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


            //Generate scores
            ret.ranked_score = rand.Next(100000000, 900000000);
            ret.total_score = rand.Next(ret.ranked_score, 1900000000);
            ret.play_count = rand.Next(1000, 50000);
            ret.play_count_daily = rand.Next(1, 40);
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

        private Country generateCountry() {
            Country country = new Country();
            string[] CountryList = new string[197] { "Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua and Barbuda", "Argentina", "Armenia", "Australia", "Austria", "Azerbaijan", "Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bhutan", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Brazil", "Brunei", "Bulgaria", "Burkina Faso", "Burundi", "Cabo Verde", "Cambodia", "Cameroon", "Canada", "Central African Republic", "Chad", "Chile", "China", "Colombia", "Comoros", "Democratic Republic of The Congo", "Republic of The Congo", "Costa Rica", "Cote d'Ivoire", "Croatia", "Cuba", "Cyprus", "Czhechia", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Eswatini", "Ethiopia", "Fiji", "Finland", "France", "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Greece", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland", "Israel", "Italy", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Kosovo", "Kuwait", "Kyrgyztan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Mauritania", "Mauritius", "Mexico", "Micronesia", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "Myanmar", "Namibia", "Nauru", "Nepal", "Netherlands", "New Zealand", "Nicaragua", "Niger", "Nigeria", "North Korea", "North Macedonia", "Norway", "Oman", "Pakistan", "Palau", "Palestine", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Qatar", "Romania", "Russia", "Rwanda", "Saint Kitts and Nevis", "Saint Lucia", "Saint Vincent and the Grenadines", "Samoa", "San Marino", "Sao Tome and Principe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "South Korea", "South Sudan", "Spain", "Sri Lanka", "Sudan", "Suriname", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Timor-Leste", "Togo", "Tonga", "Trindad and Tobago", "Tunisia", "Turkey", "Turkemenistan", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States of America", "Uruguay", "Uzebekistan", "Vanuatu", "Vatican City", "Venezuala", "Vietnam", "Yemen", "Zambia", "Zimbabwe" };
            Random Countries = new Random();
            country.name= CountryList[Countries.Next(0, 196)];
            return country;
        }

        public UserTemplate getUser() {
            return this.userTemp;
        }
    }
}
