﻿//<Falcon Orchestrator provides automated workflow and response capabilities>
//    Copyright(C) 2016 CrowdStrike

//   This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU Affero General Public License as
//    published by the Free Software Foundation, either version 3 of the
//    License, or(at your option) any later version.

//   This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
//    GNU Affero General Public License for more details.

//    You should have received a copy of the GNU Affero General Public License
//    along with this program.If not, see<http://www.gnu.org/licenses/>.


using DotNet.Highcharts;

namespace FalconOrchestratorWeb.Models.Dashboard
{

    public class DashboardViewModel
    {
        public Highcharts DetectionsBySeverity { get; set; }
        public Highcharts DetectionsByStatus { get; set; }

        public Highcharts DetectionsByType { get; set; }

        public Highcharts DetectionsByTaxonomy { get; set; }
        public Highcharts DetectionsByHandlerAndStatus { get; set; }

        public Highcharts DetectionsByUserDepartment { get; set; }
        public Highcharts DetectionsByUserCountry { get; set; }
        public Highcharts DetectionsByUserJobTitle { get; set; }
        public string AverageDetectionsPerDay { get; set; }
        public string AverageDetectionsPerWeek { get; set; }
        public string AverageDetectionsPerMonth { get; set; }

    }
}