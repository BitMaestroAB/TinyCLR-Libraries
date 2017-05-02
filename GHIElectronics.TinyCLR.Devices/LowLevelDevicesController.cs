﻿using GHIElectronics.TinyCLR.Devices.Adc.Provider;
using GHIElectronics.TinyCLR.Devices.Dac.Provider;
using GHIElectronics.TinyCLR.Devices.Display.Provider;
using GHIElectronics.TinyCLR.Devices.Gpio.Provider;
using GHIElectronics.TinyCLR.Devices.I2c.Provider;
using GHIElectronics.TinyCLR.Devices.Pwm.Provider;
using GHIElectronics.TinyCLR.Devices.Spi.Provider;

namespace GHIElectronics.TinyCLR.Devices {
    public sealed class LowLevelDevicesController {
        public static ILowLevelDevicesAggregateProvider DefaultProvider { get; set; }
    }

    public interface ILowLevelDevicesAggregateProvider {
        IAdcControllerProvider AdcControllerProvider { get; }
        IDacControllerProvider DacControllerProvider { get; }
        IDisplayControllerProvider DisplayControllerProvider { get; }
        IGpioControllerProvider GpioControllerProvider { get; }
        II2cControllerProvider I2cControllerProvider { get; }
        IPwmControllerProvider PwmControllerProvider { get; }
        ISpiControllerProvider SpiControllerProvider { get; }
    }

    public sealed class LowLevelDevicesAggregateProvider : ILowLevelDevicesAggregateProvider {
        public IAdcControllerProvider AdcControllerProvider { get; }
        public IDacControllerProvider DacControllerProvider { get; }
        public IDisplayControllerProvider DisplayControllerProvider { get; }
        public IGpioControllerProvider GpioControllerProvider { get; }
        public II2cControllerProvider I2cControllerProvider { get; }
        public IPwmControllerProvider PwmControllerProvider { get; }
        public ISpiControllerProvider SpiControllerProvider { get; }

        public LowLevelDevicesAggregateProvider(IAdcControllerProvider adc, IDacControllerProvider dac, IDisplayControllerProvider display, IPwmControllerProvider pwm, IGpioControllerProvider gpio, II2cControllerProvider i2c, ISpiControllerProvider spi) {
            this.AdcControllerProvider = adc;
            this.DacControllerProvider = dac;
            this.DisplayControllerProvider = display;
            this.PwmControllerProvider = pwm;
            this.GpioControllerProvider = gpio;
            this.I2cControllerProvider = i2c;
            this.SpiControllerProvider = spi;
        }
    }

    internal static class DefaultDeviceNames {
        public static string AdcProvider = "TinyCLR.Default.AdcProvider";
        public static string DacProvider = "TinyCLR.Default.DacProvider";
        public static string DisplayProvider = "TinyCLR.Default.DisplayProvider";
        public static string GpioProvider = "TinyCLR.Default.GpioProvider";
    }
}
