/*
 * Message360.PCL
 *
 * This file was automatically generated for message360 by APIMATIC v2.0 ( https://apimatic.io ) on 10/21/2016
 */
using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using message360;

namespace message360.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum AudioFormat
    {
        MP3, //mp3 file
        WAV, //wav file
    }

    /// <summary>
    /// Helper for the enum type AudioFormat
    /// </summary>
    public static class AudioFormatHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "mp3", "wav" };

        /// <summary>
        /// Converts a AudioFormat value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The AudioFormat value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(AudioFormat enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case AudioFormat.MP3:
                case AudioFormat.WAV:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of AudioFormat values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of AudioFormat values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<AudioFormat> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into AudioFormat value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed AudioFormat value</returns>
        public static AudioFormat ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type AudioFormat", value));

            return (AudioFormat) index;
        }
    }
} 