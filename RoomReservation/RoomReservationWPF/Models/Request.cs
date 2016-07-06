﻿using RoomReservationWPF.Models;
namespace RoomReservation.Models
{
    using RoomReservationWPF.Common;
    using RoomReservationWPF.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Request : IRoom
    {
        private int capacity;
        private enumCapacityRange capacityRange;
        private int floor;
        private List<MultimediaDevice> listMultimedia;
        private Location location;
        private decimal rentPricePerHour;
        private enumRentPriceRange rentPriceRange;
        private enumRoomTypes roomType;

        public Request( 
            int capacity,
            enumCapacityRange capacityRange,
            int floor,
            List<MultimediaDevice> listMultimedia,
            Location location,
            decimal RentPricePerHour,
            enumRentPriceRange rentPriceRange,
            enumRoomTypes roomType)
        {
            //Room modelDesiredRoom = new Room(roomType, capacity, listMultimedia, rentPriceRange, location);
            this.Capacity = capacity;
            this.CapacityRange = capacityRange;
            this.Floor = floor;
            this.ListMultimedia = listMultimedia;
            this.Location = location;
            this.RentPricePerHour = rentPricePerHour;
            this.RentPriceRange = rentPriceRange;
            this.RoomType = roomType;
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Capacity must be greater then 0");
                }

                this.capacity = value;
            }
        }

        public enumCapacityRange CapacityRange
        {
            get
            {
                return this.capacityRange;
            }

            set
            {
                // implement validation if needed
                this.capacityRange = value;
            }
        }

        public int Floor
        {
            get
            {
                return this.floor;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Floor must be greater then 0");
                }

                this.floor = value;
            }
        }

        public List<MultimediaDevice> ListMultimedia
        {
            get
            {
                return this.listMultimedia;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("List of multimedia divices must be set!");
                }

                this.listMultimedia = value;
            }
        }

        public Location Location
        {
            get
            {
                return this.location;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Location must be set!");
                }

                this.location = value;
            }
        }

        public decimal RentPricePerHour
        {
            get
            {
                return this.rentPricePerHour;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("RentPricePerHour must be greater then zero");
                }

                this.rentPricePerHour = value;
            }
        }

        public enumRentPriceRange RentPriceRange
        {
            get
            {
                return this.rentPriceRange;
            }

            set
            {
                // implement validation if needed
                this.rentPriceRange = value;
            }
        }

        public enumRoomTypes RoomType
        {
            get
            {
                return this.roomType;
            }

            set
            {
                //impelement validation if needed
                this.roomType = value;
            }
        }
    }
}
