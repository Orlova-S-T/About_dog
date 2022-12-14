double firstFriendSpeed = 4;
double secondFriendSpeed = 5;
double dogSpeed = 10;
double distance = 1000;
double distanceLimit = 10;
double speed = 0; //Не знаю, нужно ли.
double timeToMeet = 0; //Не знаю, нужно ли.
int dogCounter = 0;
int dogDirection = 1;

while(distance > distanceLimit)
{
  speed = 0;
  if(dogDirection == 1)
	{
    speed = firstFriendSpeed + dogSpeed;
    dogDirection = 2;
	}
  else
	{
    speed = secondFriendSpeed + dogSpeed;
    dogDirection = 1;
	}
  timeToMeet = distance / speed;
  distance = distance - timeToMeet * (firstFriendSpeed + secondFriendSpeed);
  dogCounter = dogCounter + 1;
}
Console.Write("Собака пробежит между друзьями ");
Console.Write(dogCounter);
Console.WriteLine(" раз");
Console.Write("Расстояние при встрече будет равно ");
Console.WriteLine(distance);

