public class Tuple<F, S, T>
{
    private F firstItem;
    private S secondItem;
    private T thridItem;
    public Tuple(F firstItem, S secondItem, T thirdItem)
    {
        this.firstItem = firstItem;
        this.secondItem = secondItem;
        this.thridItem = thirdItem;
    }

    public F FirstItem { get => this.firstItem; }

    public S SecondItem { get => this.secondItem; }

    public T ThirdItem { get => this.thridItem; }

    public override string ToString()
    {
        return $"{this.firstItem.ToString()} -> {this.secondItem.ToString()} -> {this.ThirdItem.ToString()}";
    }
}

