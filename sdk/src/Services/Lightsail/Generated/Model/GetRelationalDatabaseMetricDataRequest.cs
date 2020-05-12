/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the GetRelationalDatabaseMetricData operation.
    /// Returns the data points of the specified metric for a database in Amazon Lightsail.
    /// </summary>
    public partial class GetRelationalDatabaseMetricDataRequest : AmazonLightsailRequest
    {
        private DateTime? _endTime;
        private RelationalDatabaseMetricName _metricName;
        private int? _period;
        private string _relationalDatabaseName;
        private DateTime? _startTime;
        private List<string> _statistics = new List<string>();
        private MetricUnit _unit;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end of the time interval from which to get metric data.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specified in Coordinated Universal Time (UTC).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specified in the Unix time format.
        /// </para>
        ///  
        /// <para>
        /// For example, if you wish to use an end time of October 1, 2018, at 8 PM UTC, then
        /// you input <code>1538424000</code> as the end time.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The metric for which you want to return information.
        /// </para>
        ///  
        /// <para>
        /// Valid relational database metric names are listed below, along with the most useful
        /// <code>statistics</code> to include in your request, and the published <code>unit</code>
        /// value. All relational database metric data is available in 1-minute (60 seconds) granularity.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <code>CPUUtilization</code> </b> - The percentage of CPU utilization currently
        /// in use on the database.
        /// </para>
        ///  
        /// <para>
        ///  <code>Statistics</code>: The most useful statistics are <code>Maximum</code> and
        /// <code>Average</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>Unit</code>: The published unit is <code>Percent</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>DatabaseConnections</code> </b> - The number of database connections in
        /// use.
        /// </para>
        ///  
        /// <para>
        ///  <code>Statistics</code>: The most useful statistics are <code>Maximum</code> and
        /// <code>Sum</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>Unit</code>: The published unit is <code>Count</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>DiskQueueDepth</code> </b> - The number of outstanding IOs (read/write
        /// requests) that are waiting to access the disk.
        /// </para>
        ///  
        /// <para>
        ///  <code>Statistics</code>: The most useful statistic is <code>Sum</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>Unit</code>: The published unit is <code>Count</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>FreeStorageSpace</code> </b> - The amount of available storage space.
        /// </para>
        ///  
        /// <para>
        ///  <code>Statistics</code>: The most useful statistic is <code>Sum</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>Unit</code>: The published unit is <code>Bytes</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>NetworkReceiveThroughput</code> </b> - The incoming (Receive) network traffic
        /// on the database, including both customer database traffic and AWS traffic used for
        /// monitoring and replication.
        /// </para>
        ///  
        /// <para>
        ///  <code>Statistics</code>: The most useful statistic is <code>Average</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>Unit</code>: The published unit is <code>Bytes/Second</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>NetworkTransmitThroughput</code> </b> - The outgoing (Transmit) network
        /// traffic on the database, including both customer database traffic and AWS traffic
        /// used for monitoring and replication.
        /// </para>
        ///  
        /// <para>
        ///  <code>Statistics</code>: The most useful statistic is <code>Average</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>Unit</code>: The published unit is <code>Bytes/Second</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public RelationalDatabaseMetricName MetricName
        {
            get { return this._metricName; }
            set { this._metricName = value; }
        }

        // Check to see if MetricName property is set
        internal bool IsSetMetricName()
        {
            return this._metricName != null;
        }

        /// <summary>
        /// Gets and sets the property Period. 
        /// <para>
        /// The granularity, in seconds, of the returned data points.
        /// </para>
        ///  
        /// <para>
        /// All relational database metric data is available in 1-minute (60 seconds) granularity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=60, Max=86400)]
        public int Period
        {
            get { return this._period.GetValueOrDefault(); }
            set { this._period = value; }
        }

        // Check to see if Period property is set
        internal bool IsSetPeriod()
        {
            return this._period.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RelationalDatabaseName. 
        /// <para>
        /// The name of your database from which to get metric data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RelationalDatabaseName
        {
            get { return this._relationalDatabaseName; }
            set { this._relationalDatabaseName = value; }
        }

        // Check to see if RelationalDatabaseName property is set
        internal bool IsSetRelationalDatabaseName()
        {
            return this._relationalDatabaseName != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start of the time interval from which to get metric data.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specified in Coordinated Universal Time (UTC).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specified in the Unix time format.
        /// </para>
        ///  
        /// <para>
        /// For example, if you wish to use a start time of October 1, 2018, at 8 PM UTC, then
        /// you input <code>1538424000</code> as the start time.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Statistics. 
        /// <para>
        /// The statistic for the metric.
        /// </para>
        ///  
        /// <para>
        /// The following statistics are available:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Minimum</code> - The lowest value observed during the specified period. Use
        /// this value to determine low volumes of activity for your application.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Maximum</code> - The highest value observed during the specified period. Use
        /// this value to determine high volumes of activity for your application.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Sum</code> - All values submitted for the matching metric added together. You
        /// can use this statistic to determine the total volume of a metric.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Average</code> - The value of Sum / SampleCount during the specified period.
        /// By comparing this statistic with the Minimum and Maximum values, you can determine
        /// the full scope of a metric and how close the average use is to the Minimum and Maximum
        /// values. This comparison helps you to know when to increase or decrease your resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SampleCount</code> - The count, or number, of data points used for the statistical
        /// calculation.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Statistics
        {
            get { return this._statistics; }
            set { this._statistics = value; }
        }

        // Check to see if Statistics property is set
        internal bool IsSetStatistics()
        {
            return this._statistics != null && this._statistics.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The unit for the metric data request. Valid units depend on the metric data being
        /// required. For the valid units with each available metric, see the <code>metricName</code>
        /// parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MetricUnit Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this._unit != null;
        }

    }
}