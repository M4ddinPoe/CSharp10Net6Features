namespace FieldKeyword;

public class FieldKeyword
{
    private string _someTextProperty = string.Empty;
    
    public string SomeTextProperty
    {
        get => this._someTextProperty;
        set
        {
            string trimmed = value.Trim();
            ArgumentNullException.ThrowIfNull(trimmed);

            this._someTextProperty = value;
        }
    }
   
}