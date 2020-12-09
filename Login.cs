public partial class app
{
    public object_button(){
        if (UserName.Text=="Admin" && Password.Text=="Arash")
        {
            Form news = new Dashboard();
            Hide();
            news.Show();
        }
        else
        {
            Messagebox.Show("نام کاربری یا رمز عبور شما غلط است.");
        }
    }
    public class object_exit{
        Close();
    }
        }

internal struct NewStruct
{
    public Dataset.Text Item1;
    public object Item2;

    public NewStruct(Dataset.Text item1, object item2)
    {
        Item1 = item1;
        Item2 = item2;
    }

    public override bool Equals(object obj)
    {
        return obj is NewStruct other &&
               System.Collections.Generic.EqualityComparer<Dataset.Text>.Default.Equals(Item1, other.Item1) &&
               System.Collections.Generic.EqualityComparer<object>.Default.Equals(Item2, other.Item2);
    }

    public override int GetHashCode()
    {
        int hashCode = -1030903623;
        hashCode = hashCode * -1521134295 + System.Collections.Generic.EqualityComparer<Dataset.Text>.Default.GetHashCode(Item1);
        hashCode = hashCode * -1521134295 + System.Collections.Generic.EqualityComparer<object>.Default.GetHashCode(Item2);
        return hashCode;
    }

    public void Deconstruct(out Dataset.Text item1, out object item2)
    {
        item1 = Item1;
        item2 = Item2;
    }

    public static implicit operator (Dataset.Text, object)(NewStruct value)
    {
        return (value.Item1, value.Item2);
    }

    public static implicit operator NewStruct((Dataset.Text, object) value)
    {
        return new NewStruct(value.Item1, value.Item2);
    }
}

internal struct NewStruct1
{
    public Dataset.Text Item1;
    public object Item2;

    public NewStruct1(Dataset.Text item1, object item2)
    {
        Item1 = item1;
        Item2 = item2;
    }

    public override bool Equals(object obj)
    {
        return obj is NewStruct1 other &&
               System.Collections.Generic.EqualityComparer<Dataset.Text>.Default.Equals(Item1, other.Item1) &&
               System.Collections.Generic.EqualityComparer<object>.Default.Equals(Item2, other.Item2);
    }

    public override int GetHashCode()
    {
        int hashCode = -1030903623;
        hashCode = hashCode * -1521134295 + System.Collections.Generic.EqualityComparer<Dataset.Text>.Default.GetHashCode(Item1);
        hashCode = hashCode * -1521134295 + System.Collections.Generic.EqualityComparer<object>.Default.GetHashCode(Item2);
        return hashCode;
    }

    public void Deconstruct(out Dataset.Text item1, out object item2)
    {
        item1 = Item1;
        item2 = Item2;
    }

    public static implicit operator (Dataset.Text, object)(NewStruct1 value)
    {
        return (value.Item1, value.Item2);
    }

    public static implicit operator NewStruct1((Dataset.Text, object) value)
    {
        return new NewStruct1(value.Item1, value.Item2);
    }
}

internal struct NewStruct2
{
    public object Item1;
    public object Item2;

    public NewStruct2(object item1, object item2)
    {
        Item1 = item1;
        Item2 = item2;
    }

    public override bool Equals(object obj)
    {
        return obj is NewStruct2 other &&
               System.Collections.Generic.EqualityComparer<object>.Default.Equals(Item1, other.Item1) &&
               System.Collections.Generic.EqualityComparer<object>.Default.Equals(Item2, other.Item2);
    }

    public override int GetHashCode()
    {
        int hashCode = -1030903623;
        hashCode = hashCode * -1521134295 + System.Collections.Generic.EqualityComparer<object>.Default.GetHashCode(Item1);
        hashCode = hashCode * -1521134295 + System.Collections.Generic.EqualityComparer<object>.Default.GetHashCode(Item2);
        return hashCode;
    }

    public void Deconstruct(out object item1, out object item2)
    {
        item1 = Item1;
        item2 = Item2;
    }

    public static implicit operator (object, object)(NewStruct2 value)
    {
        return (value.Item1, value.Item2);
    }

    public static implicit operator NewStruct2((object, object) value)
    {
        return new NewStruct2(value.Item1, value.Item2);
    }
}

internal struct NewStruct3
{
    public object Item1;
    public object Item2;

    public NewStruct3(object item1, object item2)
    {
        Item1 = item1;
        Item2 = item2;
    }

    public override bool Equals(object obj)
    {
        return obj is NewStruct3 other &&
               System.Collections.Generic.EqualityComparer<object>.Default.Equals(Item1, other.Item1) &&
               System.Collections.Generic.EqualityComparer<object>.Default.Equals(Item2, other.Item2);
    }

    public override int GetHashCode()
    {
        int hashCode = -1030903623;
        hashCode = hashCode * -1521134295 + System.Collections.Generic.EqualityComparer<object>.Default.GetHashCode(Item1);
        hashCode = hashCode * -1521134295 + System.Collections.Generic.EqualityComparer<object>.Default.GetHashCode(Item2);
        return hashCode;
    }

    public void Deconstruct(out object item1, out object item2)
    {
        item1 = Item1;
        item2 = Item2;
    }

    public static implicit operator (object, object)(NewStruct3 value)
    {
        return (value.Item1, value.Item2);
    }

    public static implicit operator NewStruct3((object, object) value)
    {
        return new NewStruct3(value.Item1, value.Item2);
    }
}