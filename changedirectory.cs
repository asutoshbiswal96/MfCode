

using System;
using System.Collections.Generic;
using System.Linq;

namespace file
{
    public class Path
    {
        public string CurrentPath { get; private set; }

        public Path(string path)
        {
            CurrentPath = path;
        }
        public void cd(string changePathTo)
        {
            if (changePathTo == "/")
            {
                CurrentPath = "/";
                return;
            }
            int lengthofchangePathTo = changePathTo.Length;
            while (lengthofchangePathTo > 0)
            {
                #region removes .. in changetoPth

                try
                {
                    if (lengthofchangePathTo > 1)
                    {
                        if (changePathTo[0] == '.' && changePathTo[1] == '.')
                        {
                            if (!String.IsNullOrEmpty(CurrentPath))
                            {
                                CurrentPath = CurrentPath.Remove(CurrentPath.LastIndexOf("/", StringComparison.Ordinal));
                                if (String.IsNullOrEmpty(CurrentPath))
                                {
                                    CurrentPath = "/";
                                }
                            }

                            changePathTo = changePathTo.Remove(0, 2);
                            lengthofchangePathTo -= 2;
                            continue;
                        }
                        lengthofchangePathTo -= 2;
                    }
                }
                catch (Exception exp)
                {

                }
                #endregion
                if (changePathTo[0] == '/')
                {
                    changePathTo = changePathTo.Remove(0, 1);
                    if (changePathTo[0] == '.')
                    {
                        continue;
                    }
                }

                if (CurrentPath.Last() != '/')
                {
                    CurrentPath += "/";
                }
                #region append to the currentpath
                var index = changePathTo.IndexOf("/", StringComparison.Ordinal);
                if (index == -1)
                {
                    CurrentPath += changePathTo;
                    changePathTo = "";
                }
                else
                {
                    CurrentPath += changePathTo.Substring(0, index);
                    changePathTo = changePathTo.Remove(0, index);
                }
                #endregion
            }
        }
        public static void Main()
        {
            Path path = new Path("/a/b/c/d");
            path.cd("../x");
            Console.WriteLine(path.CurrentPath);
            Console.ReadLine();

        }
    }
}

