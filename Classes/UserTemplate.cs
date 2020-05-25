using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ihcProject.Classes
{   
    // TODO Add new parameters as necessary
    public class UserTemplate
    {
        public string avatar_url { get; set; }
        public string country_code { get; set; }
        public string default_group { get; set; }
        public int id { get; set; }
        public bool is_active { get; set; }
        public bool is_bot { get; set; }
        public bool is_online { get; set; }
        public bool is_supporter { get; set; }
        public DateTime last_visit { get; set; }    //To randomize
        public bool pm_friends_only { get; set; }
        public object profile_colour { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        public string cover_url { get; set; }
        public object discord { get; set; }
        public bool has_supported { get; set; }
        public object interests { get; set; }
        public DateTime join_date { get; set; }
        public Kudosu kudosu { get; set; }
        public object lastfm { get; set; }
        public object location { get; set; }
        public int max_blocks { get; set; }
        public int max_friends { get; set; }
        public object occupation { get; set; }
        public string playmode { get; set; }
        public string[] playstyle { get; set; }
        public int post_count { get; set; }
        public string[] profile_order { get; set; }
        public object skype { get; set; }
        public object title { get; set; }
        public object twitter { get; set; }
        public object website { get; set; }
        public Country country { get; set; }
        public Cover cover { get; set; }
        public object[] account_history { get; set; }
        public object[] active_tournament_banner { get; set; }
        public object[] badges { get; set; }
        public int favourite_beatmapset_count { get; set; }
        public int follower_count { get; set; }
        public int graveyard_beatmapset_count { get; set; }
        public int loved_beatmapset_count { get; set; }
        public Monthly_Playcounts[] monthly_playcounts { get; set; }
        public Weekly_Playcount weekly_playcount { get; set; }
        public object[] previous_usernames { get; set; }
        public int ranked_and_approved_beatmapset_count { get; set; }
        public object[] replays_watched_counts { get; set; }
        public int scores_first_count { get; set; }
        public Statistics statistics { get; set; }
        public Recent_High_Scores recent_high_scores { get; set; }
        public int support_level { get; set; }
        public int unranked_beatmapset_count { get; set; }
        public User_Achievements[] user_achievements { get; set; }
        public object rankHistory { get; set; }
        public Profile_Choices profile_choices { get; set; }
        public profile_specs profile_specs { get; set; }
    }

    public class Kudosu
    {
        public int total { get; set; }
        public int available { get; set; }
    }

    public class Country
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class Cover
    {
        public object custom_url { get; set; }
        public string url { get; set; }
        public string id { get; set; }
    }

    public class Statistics
    {
        public Level level { get; set; }
        public int pp { get; set; }
        public int pp_change { get; set; }
        public int pp_rank { get; set; }
        public int ranked_score { get; set; }
        public int total_score { get; set; }
        public double hit_accuracy { get; set; }
        public int play_count { get; set; }
        public int play_count_daily { get; set; }
        public int play_time { get; set; }
        public int total_hits { get; set; }
        public int maximum_combo { get; set; }
        public int replays_watched_by_others { get; set; }
        public bool is_ranked { get; set; }
        public Grade_Counts grade_counts { get; set; }
        public Rank rank { get; set; }
        public int daily_performance_gain { get; set; }
        public int weekly_performance_gain { get; set; }
        public int monthly_performance_gain { get; set; }
        public int yearly_performance_gain { get; set; }
        public int daily_rank_gain { get; set; }
        public int weekly_rank_gain { get; set; }
        public int monthly_rank_gain { get; set; }
        public int yearly_rank_gain { get; set; }
    }

    public class Level
    {
        public int current { get; set; }
        public int progress { get; set; }
    }

    public class Grade_Counts
    {
        public int ss { get; set; }
        public int ssh { get; set; }
        public int s { get; set; }
        public int sh { get; set; }
        public int a { get; set; }
    }

    public class Rank
    {
        public object global { get; set; }
        public object country { get; set; }
        public int rank_change { get; set; }
    }

    public class Monthly_Playcounts
    {
        public string start_date { get; set; }
        public int count { get; set; }
    }

    public class Weekly_Playcount {
        public int total_count {get; set;}
        public int count_standard { get; set; }
        public int count_taiko { get; set; }
        public int count_ctb { get; set; }
        public int count_mania { get; set; }
    }

    public class User_Achievements
    {
        public DateTime achieved_at { get; set; }
        public int achievement_id { get; set; }
    }

    public class Profile_Choices { 
        public int cb1_item { get; set; }
        public int cb2_item { get; set; }
        public int cb3_item { get; set; }
        public int cb4_item { get; set; }
        public int pss_item { get; set; }
    }

    public class profile_specs {
        public double star { get; set; }
        public double speed { get; set; }
        public double ad { get; set; }
        public string avgBeatmapTime { get; set; }
        public int avgBPM {get; set; }
        public double cs { get; set; }
        public double ar { get; set; }
        public double od { get; set; }
        public double hp { get; set; }
    }
    public class Recent_High_Scores {
        public string[] maps { get; set; }
        public int[] ranks { get; set; }
        public string[] mods { get; set; }
        public DateTime[] dates { get; set; }
        public int[] pps { get; set; }
        public int[] scores { get; set; }
    }
}
