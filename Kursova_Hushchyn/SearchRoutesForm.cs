﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova_Hushchyn
{
    public partial class SearchRoutesForm : Form
    {
        public RouteList routeList;

        public SearchRoutesForm(RouteList routeList)
        {
            InitializeComponent();
            this.routeList = routeList;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
                // Validate and parse the departure date
                DateTime? departureDate = null;
                if (!string.IsNullOrWhiteSpace(txtDepartureDate.Text))
                {
                    if (DateTime.TryParse(txtDepartureDate.Text, out DateTime parsedDate))
                    {
                        departureDate = parsedDate;
                    }
                    
                }
            DateTime? arrivalDate = null;
            if (!string.IsNullOrWhiteSpace(txtArrivalDate.Text))
            {
                if (DateTime.TryParse(txtDepartureDate.Text, out DateTime parsedDate))
                {
                    arrivalDate = parsedDate;
                }

            }
            TimeSpan? departureTime = null;
            if (!string.IsNullOrWhiteSpace(txtDepartureTime.Text))
            {
                if (TimeSpan.TryParse(txtDepartureTime.Text, out TimeSpan time))
                {
                    departureTime = time;
                }

            }
            TimeSpan? arrivalTime = null;
            if (!string.IsNullOrWhiteSpace(txtArrivalTime.Text))
            {
                if (TimeSpan.TryParse(txtArrivalTime.Text, out TimeSpan time))
                {
                    arrivalTime = time;
                }

            }
            // Initialize search parameters
            string departure = string.IsNullOrWhiteSpace(txtDeparture.Text) ? null : txtDeparture.Text;
                string arrival = string.IsNullOrWhiteSpace(txtArrival.Text) ? null : txtArrival.Text;
                string intermediate = string.IsNullOrWhiteSpace(txtIntermediate.Text) ? null : txtIntermediate.Text;
                string model = string.IsNullOrWhiteSpace(txtModel.Text) ? null : txtModel.Text;
                string carrierCompany = string.IsNullOrWhiteSpace(txtCarrierCompany.Text) ? null : txtCarrierCompany.Text;
                string routeNumber = string.IsNullOrWhiteSpace(txtRouteNumber.Text) ? null : txtRouteNumber.Text;
                bool? hasAirConditioner = chbConditioner.Checked ? (bool?)chbConditioner.Checked : null;
                bool? hasToilet = chbToilet.Checked ? (bool?)chbToilet.Checked : null;
                bool? hasPowerOutlets = chbPowerOutlets.Checked ? (bool?)chbPowerOutlets.Checked : null;
                bool? hasInternet = chbInternet.Checked ? (bool?)chbInternet.Checked : null;
                double? priceLow = string.IsNullOrWhiteSpace(txtPriceLow.Text) ? -1 : (double?)double.Parse(txtPriceLow.Text);
                double? priceHigh = string.IsNullOrWhiteSpace(txtPriceHigh.Text) ? -1 : (double?)double.Parse(txtPriceHigh.Text);
            int? capacity = null;
                if (!string.IsNullOrWhiteSpace(txtCapacity.Text))
                {
                    if (int.TryParse(txtCapacity.Text, out int parsedCapacity))
                    {
                        capacity = parsedCapacity;
                    }
                   
                }

            RouteList routes = new RouteList();
            routes.BusRoutes = routeList.BusRoutes;
            
            if (model != null)
            {
              //   routes = routes.SearchRoutesByModel(model);
            }

            if (hasAirConditioner != null)
            {
                routes.BusRoutes = routes.SearchRoutesByAirConditioner();
            }
            if (hasToilet != null)
            {
                routes.BusRoutes = routes.SearchRoutesByToilet();
            }
            if (hasPowerOutlets != null)
            {
                routes.BusRoutes = routes.SearchRoutesByPowerOutlets();
            }
            if (hasInternet != null)
            {
                routes.BusRoutes = routes.SearchRoutesByInternet();
            }
            if (routeNumber != null)
            {
                routes.BusRoutes = routes.SearchRoutesByRouteNumber(routeNumber);
            }
            if (carrierCompany != null)
            {
                routes.BusRoutes = routes.SearchRoutesByCarrierCompany(carrierCompany);
            }
            if ((priceLow != null && priceHigh != null) && priceHigh > priceLow)
            {
                routes.BusRoutes = routes.SearchRoutesByPrice(priceLow, priceHigh);
            }
            if (departureDate != null)
            {
                routes.BusRoutes = routes.SearchRoutesByDepartureDate((DateTime)departureDate);
            }
            if (arrivalDate != null)
            {
                routes.BusRoutes = routes.SearchRoutesByArrivalDate((DateTime)arrivalDate);
            }
            if (departureTime != null)
            {
                routes.BusRoutes = routes.SearchRoutesByDepartureTime((TimeSpan)departureTime);
            }
            if (arrivalTime != null)
            {
                routes.BusRoutes = routes.SearchRoutesByArrivalTime((TimeSpan)arrivalTime);
            }
            if (departure != null)
            {
                routes.BusRoutes = routes.SearchRoutesByDeparture(departure);
            }
            if (arrival != null)
            {
                routes.BusRoutes = routes.SearchRoutesByArrival(arrival);
            }
            /*results.SearchRoutes(
                    model,hasAirConditioner,hasToilet,hasPowerOutlets,hasInternet,routeNumber,carrierCompany,priceLow,priceHigh,departureDate,arrivalDate,departureTime,arrivalTime,departure,arrival,intermediate
                );*/

                // Display the routes (implement logic to show the routes in a grid or list)
                dgvRoutes.DataSource = routes.BusRoutes;
        }


        

        private void btnView_Click(object sender, EventArgs e)
        {
            
            dgvRoutes.DataSource = routeList.BusRoutes;
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            routeList.SaveRoutesToFile("routes.txt");
        }
    }
}
