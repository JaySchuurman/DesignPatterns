namespace FacadePattern
{
    internal class HomeTheaterFacade
    {
        private readonly Amplifier _amplifier;
        private readonly Tuner _tuner;
        private readonly DvdPlayer _dvdPlayer;
        private readonly CdPlayer _cdPlayer;
        private readonly Projector _projector;
        private readonly Screen _screen;
        private readonly TheaterLights _lights;
        private readonly PopcornPopper _popper;

        public HomeTheaterFacade(Amplifier amplifier, Tuner tuner, DvdPlayer dvdPlayer,
            CdPlayer cdPlayer, Projector projector, Screen screen, TheaterLights lights,
            PopcornPopper popper)
        {
            _amplifier = amplifier;
            _tuner = tuner;
            _dvdPlayer = dvdPlayer;
            _cdPlayer = cdPlayer;
            _projector = projector;
            _screen = screen;
            _lights = lights;
            _popper = popper;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie...");
            _popper.On();
            _popper.Pop();
            _lights.Dim(10);
            _screen.Down();
            _projector.On();
            _projector.SetInput(_dvdPlayer);
            _projector.WideScreenMode();
            _amplifier.On();
            _amplifier.SetDvd(_dvdPlayer);
            _amplifier.SetSurroundSound();
            _amplifier.SetVolume(5);
            _dvdPlayer.On();
            _dvdPlayer.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting movie theater down...");
            _popper.Off();
            _lights.On();
            _screen.Up();
            _projector.Off();
            _amplifier.Off();
            _dvdPlayer.Stop();
            _dvdPlayer.Eject();
            _dvdPlayer.Off();
        }
    }
}
