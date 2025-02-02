﻿using BookingApp.Repository;
using BookingApp.Repository.AccommodationRepositories;
using BookingApp.Serializer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BookingApp.Model
{
    public class GuestRating : INotifyPropertyChanged, ISerializable
    {
        public int ownerId { get; set; }
        public int guestId { get; set; }
        public int cleanliness { get; set; }
        public int followingGuidelines { get; set; }
        public int commentId { get; set; }
        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string str)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(str));
            }
        }
        public int OwnerId
        {
            get
            {
                return ownerId;
            }
            set
            {
                if (value != ownerId)
                {
                    ownerId = value;
                    OnPropertyChanged(nameof(ownerId));
                }
            }
        }
        public int GuestId
        {
            get
            {
                return guestId;
            }
            set
            {
                if (value != guestId)
                {
                    guestId = value;
                    OnPropertyChanged(nameof(guestId));
                }
            }
        }
        public int Cleanliness
        {
            get
            {
                return cleanliness;
            }
            set
            {
                if (value != cleanliness)
                {
                    cleanliness = value;
                    OnPropertyChanged(nameof(cleanliness));
                }
            }
        }
        public int FollowingGuidelines
        {
            get
            {
                return followingGuidelines;
            }
            set
            {
                if (value != followingGuidelines)
                {
                    followingGuidelines = value;
                    OnPropertyChanged(nameof(followingGuidelines));
                }
            }
        }
        public int CommentId
        {
            get
            {
                return commentId;
            }
            set
            {
                if (value != commentId)
                {
                    commentId = value;
                    OnPropertyChanged(nameof(commentId));
                }
            }
        }

        public GuestRating() { }
        public GuestRating(int ownerId, int guestId, int cleanliness, int followingGuidelines)
        {
            this.ownerId = ownerId;
            this.guestId = guestId;
            this.cleanliness = cleanliness;
            this.followingGuidelines = followingGuidelines;
        }
        public string[] ToCSV()
        {
            string[] csvValues = {
                OwnerId.ToString(),
                GuestId.ToString(),
                Cleanliness.ToString(),
                FollowingGuidelines.ToString(),
                CommentId.ToString()
            };
            return csvValues;
        }
        public void FromCSV(string[] values)
        {
            this.OwnerId = Convert.ToInt32(values[0]);
            this.GuestId = Convert.ToInt32(values[1]);
            this.Cleanliness = Convert.ToInt32(values[2]);
            this.FollowingGuidelines = Convert.ToInt32(values[3]);
            this.CommentId = Convert.ToInt32(values[4]);
        }
        /*public string Print
        {
            get
            {
                ReservedAccommodationRepository reservedAccommodationRepository = new ReservedAccommodationRepository();
                foreach(ReservedAccommodation reservedAccommodation in reservedAccommodationRepository.GetAll())
                {
                    if(guestId == reservedAccommodation.guestId)
                    {

                    }
                }
                return "Remaining " + DateTime.Now - tempReservedAccommodation.checkOutDate).Days -  + " days to rate the user: " + username;
            }
            set
            {
                if (value != Print)
                {
                    Print = value;
                    OnPropertyChanged("Print");
                }
            }
        }*/
    }
}
