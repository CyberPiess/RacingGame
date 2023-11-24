public class BabaYagaStupa: AirTransport
{
    public BabaYagaStupa() 
    {
        Name = "Ступа Бабы Яги";
        Speed = randomNumber.Next(1, 100);
    }

    protected override void Acceleration()
    {
        AccelerationFactor = (Speed * 2 - Speed * 1) / (2 - 1);
    }
}

