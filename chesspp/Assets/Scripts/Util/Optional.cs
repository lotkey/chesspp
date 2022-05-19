public class Optional<T>
{
    public bool HasValue { get; protected set; }
    protected T m_value;

    public T Value
    {
        get
        {
            if (HasValue)
                return m_value;
            else
                throw new System.Exception("Optional does not have Value.");
        }
    }

    public Optional(T value)
    {
        m_value = value;
        HasValue = true;
    }

    public override bool Equals(object obj)
    {
        return obj is Optional<T> && this.Equals((Optional<T>)obj);
    }

    public bool Equals(Optional<T> other)
    {
        return HasValue == other.HasValue && object.Equals(Value, other.Value);
    }

    public static explicit operator T(Optional<T> optional)
    {
        return optional.Value;
    }

    public static implicit operator Optional<T>(T value)
    {
        return new Optional<T>(value);
    }
}