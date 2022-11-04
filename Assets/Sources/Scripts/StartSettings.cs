static public class StartSettings
{
    static public float PlayerVerticalSpeed
    {
        get { return _playerVerticalSpeed; }
        private set { _playerVerticalSpeed = value; }
    }
    static public float CoeffUp
    {
        get { return _coeffUp; }
        private set { _coeffUp = value; }
    }

    static public StartPlayerSettings EasySettings = new StartPlayerSettings(EASY_VERTICAL_SPEED, EASY_COEFF_UP);
    static public StartPlayerSettings MediumSettings = new StartPlayerSettings(MEDIUM_VERTICAL_SPEED, MEDIUM_COEFF_UP);
    static public StartPlayerSettings HardSettings = new StartPlayerSettings(HARD_VERTICAL_SPEED, HARD_COEFF_UP);

    private const float EASY_VERTICAL_SPEED = 3;
    private const float MEDIUM_VERTICAL_SPEED = 5;
    private const float HARD_VERTICAL_SPEED = 8;

    private const float EASY_COEFF_UP = 1.1f;
    private const float MEDIUM_COEFF_UP = 1.25f;
    private const float HARD_COEFF_UP = 1.4f;

    // Значения по дефолту.
    static private float _playerVerticalSpeed = MEDIUM_VERTICAL_SPEED;
    static private float _coeffUp = MEDIUM_COEFF_UP;

    /// <summary>
    /// Установка скорости и коеффицента ускорения от выбранной сложности
    /// </summary>
    /// <param name="startPlayerSettings"></param>
    static public void SetStartPlayerSettings(StartPlayerSettings startPlayerSettings)
    {
        PlayerVerticalSpeed = startPlayerSettings.PlayerVerticalSpeed;
        CoeffUp = startPlayerSettings.CoeffUp;
    }

    public struct StartPlayerSettings
    {
        public float PlayerVerticalSpeed { get; }
        public float CoeffUp { get; }

        public StartPlayerSettings(float verticalSpeed, float coeffUp)
        {
            PlayerVerticalSpeed = verticalSpeed;
            CoeffUp = coeffUp;
        }
    }
}