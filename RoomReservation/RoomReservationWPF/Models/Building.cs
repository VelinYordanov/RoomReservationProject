﻿namespace RoomReservation.Models
{
    using System;

    using RoomReservationWPF.Common;

    public class Building
    {
        // Fields
        //private int buildingID;
        //private BuildingType buildingType;
        //private BuildingLocationType buildingLocation;
        //private int roomCount;
        //private int floors;
        //private Coordinates coordinates;
        //for future use

        private static int buildingIdGenerator = 1;
        private int buildingID;
        // Constructor

        public Building(
        BuildingLocationType buildingLocation,
        BuildingType buildingType,
        int roomCount,
        int floors,
        Coordinates coordinate)
        {
            this.BuildingID = buildingIdGenerator++;
            this.BuildingLocation = buildingLocation;
            this.BuildingType = buildingType;
            this.RoomCount = roomCount;
            this.Floors = floors;
            this.Coordinate = coordinate;
        }

        // Properties
        public int BuildingID
        {
            get { return this.buildingID; }
            private set { this.buildingID = value; }
        }

        public BuildingType BuildingType { get; private set; }
        
        public Coordinates Coordinate { get; private set; }

        public BuildingLocationType BuildingLocation { get; private set; }
        
        public int RoomCount { get; private set; }

        public int Floors { get; private set; }
        
        public override string ToString()
        {
            return string.Format(
                "Building Id: {0}{1} Location: {2}{3} Type: {4}{5} Capacity: {6}{7} Floors: {8}{9} Coordinates: {10}{11}",
                this.BuildingID,
                Environment.NewLine,
                this.BuildingLocation,
                Environment.NewLine,
                this.BuildingType,
                Environment.NewLine,
                this.RoomCount,
                Environment.NewLine,
                this.Floors,
                Environment.NewLine,
                this.Coordinate,
                Environment.NewLine);
        }
    }
}
