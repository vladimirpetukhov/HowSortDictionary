            var filename = s;
            var rootname = s1;

Where(f => f.Key.Equals(rootname))  //Sort by given dict key-rootname
                .Select(f => f.Value) //Get value
                .First()               //First element in value
                .Where(f => f.Key.Contains("." + filename))  //Get only values that contains .filename
                .OrderByDescending(f => f.Value)  //sort values by size
                .ThenBy(f => f.Key)               //if sizes is equals sort alphabet
                .ToDictionary(f => f.Key, f => f.Value);  //Create dictionary
