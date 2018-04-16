﻿using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyTables
{
    class InteriorT
    {
        const double LARGEST_VALUE_ACCEPTED = 99999.99;
        const int NUM_DIGITS_AFTER_DECIMAL = 2;

        private string int_door_open_clearance;
        private double int_opening_measurement;
        private string int_door_easy_open;
        private double int_door_open_force;
        private string int_door_use_with_fist;
        private string five_second_close;
        private string hallway_width;
        private decimal narrowest_width;
        private string wheelchair_turnaround;
        private string hallway_obstacles;
        private string hallway_clear;
        private string lighting;
        private string lighting_type;
        private string service_counter;
        private decimal counter_height;
        private decimal writing_surface_height;
        private string drinking_fountain;
        private string comment;
        private string recommendations;

        public string Int_door_open_clearance
        {
            get => Int_door_open_clearance;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                Int_door_open_clearance = value;
            }
        }
        public double Int_opening_measurement
        {
            get => int_opening_measurement;
            set
            {
                if (value > LARGEST_VALUE_ACCEPTED)
                    throw new ArgumentOutOfRangeException();

                int_opening_measurement = Math.Round(value, NUM_DIGITS_AFTER_DECIMAL);
            }
        }
        public string Int_door_easy_open
        {
            get => int_door_easy_open;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                int_door_easy_open = value;
            }
        }
        public double Int_door_open_force
        {
            get => int_door_open_force;
            set
            {
                if (value > LARGEST_VALUE_ACCEPTED)
                    throw new ArgumentOutOfRangeException();

                int_door_open_force = Math.Round(value, NUM_DIGITS_AFTER_DECIMAL);
            }
        }
        public string Int_door_use_with_fist
        {
            get => int_door_use_with_fist;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                int_door_use_with_fist = value;
            }
        }
        public string Five_second_close
        {
            get => five_second_close;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                five_second_close = value;
            }
        }
        public string Hallway_width
        {
            get => hallway_width;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                hallway_width = value;
            }
        }
        public decimal Narrowest_width
        {
            get => narrowest_width;
            set
            {
                if (value > (decimal)LARGEST_VALUE_ACCEPTED)
                    throw new ArgumentOutOfRangeException();

                narrowest_width = (decimal)Math.Round(value, NUM_DIGITS_AFTER_DECIMAL);
            }
        }
        public string Wheelchair_turnaround
        {
            get => wheelchair_turnaround;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                wheelchair_turnaround = value;
            }
        }
        public string Hallway_obstacles
        {
            get => hallway_obstacles;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                hallway_obstacles = value;
            }
        }
        public string Hallway_clear
        {
            get => hallway_clear;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                hallway_clear = value;
            }
        }
        public string Lighting
        {
            get => lighting;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                lighting = value;
            }
        }
        public string Lighting_type
        {
            get => lighting_type;
            set
            {
                if (value.Length > 32)
                    throw new ArgumentOutOfRangeException();

                lighting_type = value;
            }
        }
        public string Service_counter
        {
            get => service_counter;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                service_counter = value;
            }
        }
        public decimal Counter_height
        {
            get => counter_height;
            set
            {
                if (value > (decimal)LARGEST_VALUE_ACCEPTED)
                    throw new ArgumentOutOfRangeException();

                counter_height = (decimal)Math.Round(value, NUM_DIGITS_AFTER_DECIMAL);
            }
        }
        public decimal Writing_surface_height
        {
            get => writing_surface_height;
            set
            {
                if (value > (decimal)LARGEST_VALUE_ACCEPTED)
                    throw new ArgumentOutOfRangeException();

                writing_surface_height = (decimal)Math.Round(value, NUM_DIGITS_AFTER_DECIMAL);
            }
        }
        public string Drinking_fountain
        {
            get => drinking_fountain;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                drinking_fountain = value;
            }
        }
        public string Comment
        {
            get => comment;
            set
            {
                comment = value;
            }
        }
        public string Recommendations
        {
            get => recommendations;
            set
            {
                recommendations = value;
            }
        }
    }
}
