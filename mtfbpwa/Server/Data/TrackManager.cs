using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mtfbpwa.Shared;

namespace mtfbpwa.Server.Data
{
    public class TrackManager
    {
        public List<Track> AllTracks { get; set; } = new List<Track>();
        public TrackManager()
        {
            AllTracks.Add(new Track
            {
                Id = 21,
                Title = "Colchester",
                Description = "'Do not let the behavior of others destroy your inner peace.' -- Dalai Lama",
                FileName = "21.mp3",
                PublishDate = "November 30, 2020"
            });

            AllTracks.Add(new Track
            {
                Id = 20,
                Title = "Pumpkin Hill",
                Description = "'The key to serenity is trusting that the universe has your back.' -- Gabrielle Bernstein",
                FileName = "20.mp3",
                PublishDate = "November 3, 2020"
            });

            AllTracks.Add(new Track
            {
                Id = 19,
                Title = "Rollinson",
                Description = "'When we are unable to find tranquility within ourselves, it is useless to seek it elsewhere.' -- Francois de La Rochefoucauld",
                FileName = "19.mp3",
                PublishDate = "February 16, 2019"
            });

            AllTracks.Add(new Track
            {
                Id = 18,
                Title = "River",
                Description = "'Do not let the behavior of others destroy your inner peace.' --Dalai Lama",
                FileName = "18.mp3",
                PublishDate = "November 4, 2018"
            });

            AllTracks.Add(new Track
            {
                Id = 17,
                Title = "Judson",
                Description = "'If everyone demanded peace instead of another television set, then there'd be peace.' -- John Lennon",
                FileName = "17.mp3",
                PublishDate = "August 6, 2018"
            });

            AllTracks.Add(new Track
            {
                Id = 16,
                Title = "Bel-Air",
                Description = "'Darkness cannot drive out darkness: only light can do that. Hate cannot drive out hate: only love can do that.'  -- Martin Luther King Jr.",
                FileName = "16.mp3",
                PublishDate = "June 19, 2018"
            });

            AllTracks.Add(new Track
            {
                Id = 15,
                Title = "Esker",
                Description = "'Learning to let go should be learned before learning to get. Life should be touched, not strangled. You’ve got to relax, let it happen at times, and at others move forward with it.' -- Ray Bradbury",
                FileName = "15.mp3",
                PublishDate = "April 22, 2018"
            });

            AllTracks.Add(new Track
            {
                Id = 14,
                Title = "Fieldcrest",
                Description = "'We cannot cure the world of sorrows, but we can choose to live in joy.' -- Joseph Campbell",
                FileName = "14.mp3",
                PublishDate = "December 11, 2017"
            });

            AllTracks.Add(new Track
            {
                Id = 13,
                Title = "Mystic",
                Description = "'Who's crazy: people who trust other people, or people who don't?' ― Lenore Skenazy",
                FileName = "13.mp3",
                PublishDate = "May 10, 2016"
            });

            AllTracks.Add(new Track
            {
                Id = 12,
                Title = "Willow",
                Description = "'The attitude of others towards you is the reflection of their state of mind.' -― Lailah Gifty Akita, Think Great: Be Great!",
                FileName = "12.mp3",
                PublishDate = "February, 2016"
            });

            AllTracks.Add(new Track
            {
                Id = 11,
                Title = "Emerson",
                Description = "'Always ask yourself: \"What will happen if I say nothing?\"' -- Kamand Kojouri",
                FileName = "11.mp3",
                PublishDate = "January, 2016"
            });

            AllTracks.Add(new Track
            {
                Id = 10,
                Title = "Cameron",
                Description = "'It was a wonderful feeling, a sense of release and boundless freedom that he had never known before. He was beyond the reach of all the things that had weighed him down and hemmed him in.' -- Michael Ende,The Neverending Story",
                FileName = "10.mp3",
                PublishDate = "November, 2015"
            });

            AllTracks.Add(new Track
            {
                Id = 9,
                Title = "Butler",
                Description = "'It's more than ok to say no to the people and places that harm your peace.' -- Nikki Rowe",
                FileName = "9.mp3",
                PublishDate = "October, 2015"
            });

            AllTracks.Add(new Track
            {
                Id = 8,
                Title = "Florence",
                Description = "'Gentleness is strength under control. It is the ability to stay calm, no matter what happens.' -- Elizabeth George",
                FileName = "8.mp3",
                PublishDate = "September, 2015"
            });

            AllTracks.Add(new Track
            {
                Id = 7,
                Title = "Parky",
                Description = "'You can't win an argument with an argument.' -- Sukant Ratnakar, Open The Windows: To the World around You",
                FileName = "7.mp3",
                PublishDate = "June, 2015"
            });

            AllTracks.Add(new Track
            {
                Id = 6,
                Title = "Spargo",
                Description = "'Ignorance might be bliss. But self-forgetfulness is pure ecstasy.' -- Kamand Kojouri",
                FileName = "6.mp3",
                PublishDate = "May, 2015"
            });

            AllTracks.Add(new Track
            {
                Id = 5,
                Title = "Moody",
                Description = "'Calm is a superpower' -- Unknown",
                FileName = "5.mp3",
                PublishDate = "April, 2015"
            });

            AllTracks.Add(new Track
            {
                Id = 4,
                Title = "Kent",
                Description = "'True peace of mind is calm in your heart that you can’t explain.' -- Ron Baratono",
                FileName = "4.mp3",
                PublishDate = "March, 2015"
            });

            AllTracks.Add(new Track
            {
                Id = 3,
                Title = "Fitch",
                Description = "Fitch is the third track that Carl created for what was then Music to Code By. If Fitch works for you, consider subscribing to get access to the entire library, with access to new tracks as they arrive.",
                FileName = "3.mp3",
                PublishDate = "February, 2015"
            });

            AllTracks.Add(new Track
            {
                Id = 2,
                Title = "Irving",
                Description = "Irving is the second track Carl created for what was then Music to Code By. If Irving works for you, consider subscribing to get access to the entire library, with access to new tracks as they arrive.",
                FileName = "2.mp3",
                PublishDate = "February, 2015"
            });

            AllTracks.Add(new Track
            {
                Id = 1,
                Title = "Garde",
                Description = "The very first track Carl Franklin wrote for what was then Music to Code By. It's only fitting that you start here. If Garde works for you, consider subscribing to get access to the entire library, with access to new tracks as they arrive.",
                FileName = "1.mp3",
                PublishDate = "February, 2015"
            });
        }
    }
}
