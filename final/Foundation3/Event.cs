using System;

public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetTitle() { return _title; }
    public string GetDescription() { return _description; }
    public string GetDate() { return _date; }
    public string GetTime() { return _time; }

    public string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress:\n{_address.GetFullAddress()}";
    }

    public virtual string GetFullDetails()
    {
                return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return $"Event: {_title} on {_date}";
    }
}
