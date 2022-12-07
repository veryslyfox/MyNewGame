interface ICell
{
    Dynamic Dynamic; 
}
enum Direct
{
    Up,
    Right,
    Down,
    Left,
}
struct Dynamic
{
    public Dynamic(Direct direct, int speed /*cell from second*/)
    {

    }
}
struct EmptyCell : ICell
{

}
struct Personage : ICell
{

}
struct Cannon : ICell
{
    public Cannon()
    {

    }
}