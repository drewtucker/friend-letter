namespace FriendLetter.Models
{
  public class LetterVariable
  {
    private string _recipient;
    private string _sender;
    private string _placeName;
    private string _nounName;

    public string GetRecipient()
    {
      return _recipient;
    }

    public void SetRecipient(string newRecipient)
    {
      _recipient = newRecipient;
    }

    public string GetSender()
    {
      return _sender;
    }

    public void SetSender(string newSender)
    {
      _sender = newSender;
    }

    public string GetPlace()
    {
      return _placeName;
    }

    public void SetPlace(string newPlace)
    {
      _placeName = newPlace;
    }

    public string GetNoun()
    {
      return _nounName;
    }

    public void SetNoun(string newNoun)
    {
      _nounName = newNoun;
    }

  }
}
