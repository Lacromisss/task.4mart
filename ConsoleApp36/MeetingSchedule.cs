using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp36
{
    internal class MeetingSchedule
    {
        public MeetingSchedule()
        {
            _meetings = new List<Meeting>();
        }
        private List<Meeting> _meetings;

        public List<Meeting> Meetings1
        {
            get => _meetings;
        }
        public void SetMeeting(string fullName, DateTime from, DateTime to)
        {
            if (from < to)
            {
                Meeting meet1 = new Meeting();
                meet1.Name = fullName;
                meet1.ToDate = to;
                meet1.FromDate = from;

                if (_meetings.Count == 0)
                {
                    _meetings.Add(meet1);
                }
                else
                {
                    bool isYes = false;
                    foreach (Meeting meet in _meetings)
                    {
                        if (from >= meet.ToDate || to <= meet.FromDate)
                        {
                            isYes = true;
                        }
                        else
                        {
                            throw new Exception("rezerv edilib");
                        }
                    }
                    if (isYes)
                        _meetings.Add(meet1);
                }
            }
            else
            {
                throw new Exception("Xetaaaaaa");
            }

        }

       
        public bool IsExistsMeetingByName(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new Exception(" Yeke adamsan bos sey daxil etme. bezdim exception elave etmekden");
            else
            {
                foreach (var item in _meetings)
                {
                    if (item.Name.Contains(text))
                        return true;
                }
                return false;
            }

        }
  
        public List<Meeting> GetExistMeetings(string text)
        {
            if (string.IsNullOrEmpty(text))
                throw new Exception("xetaaaaaaaaaa");
            else
            {
                List<Meeting> newList = new List<Meeting>();
                foreach (var item in _meetings)
                {
                    if (item.Name.Contains(text))
                        newList.Add(item);
                }
                return newList;
            }
        }
       
        public int FindMeetingsCount(DateTime dateTime)
        {
            if (dateTime == null)
            {
                throw new Exception("Xetaaaaaa");
            }
            else
            {
                int count = 0;
                foreach (var item in _meetings)
                {
                    if (dateTime < item.FromDate)
                    {
                        count++;
                    }
                }
                return count;
            }

        }
    }
}
