double distance = 10000;
double count = 0;
double firstFriendSpeed = 3;
double secondFriendSpeed = 5;
double dogSpeed = 10;
double friend = 2;
double time = 0;
while (distance > 1)
{
    if (friend == 1)
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    if (friend == 2)
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        friend = 1;
    }
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    count++;
}
Console.Write("Собака пробежит: ");
Console.Write(count);
Console.Write(" раз");