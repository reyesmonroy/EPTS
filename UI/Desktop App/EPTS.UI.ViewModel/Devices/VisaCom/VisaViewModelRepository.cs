﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devices.VisaCom.Com.Scanner;
using EPTS.Repositories.XML.Devices.Repositories;
using EPTS.Models.Devices.SEAMAX;
using EPTS.Models.Devices.VisaCom.Com.Scanner;
using EPTS.Models.Devices.VisaCom.DMM;
using EPTS.Models.Devices.VisaCom.Power;
using Scanner = EPTS.Repositories.XML.Devices.Infrastructure.Entities.VisaCom.Com.Scanner.Scanner;


namespace EPTS.UI.ViewModel.Devices.VisaCom
{
    public class VisaViewModelRepository
    {

        public ObservableCollection<Dmm> DMM { get; private set; }
        public ObservableCollection<Power> Power { get; private set; }
        public ObservableCollection<Scanner> Scanner { get; private set; }

        public VisaViewModelRepository(IDataRepositories dataRepositories)
        {
            DMM =
                new ObservableCollection<Dmm>(dataRepositories.VisaComDeviceRepository.DMM
                    .Select(c => new Dmm
                    {
                        DeviceId = c.DeviceId,
                        DeviceName = c.DeviceName,
                        DeviceDescription = c.DeviceDescription,
                        DeviceAddress = c.DeviceAddress,
                    }).ToList());
            Power = new ObservableCollection<Power>(dataRepositories.VisaComDeviceRepository.Power
                .Select(c => new Power
                {
                    DeviceId = c.DeviceId,
                    DeviceName = c.DeviceName,
                    DeviceDescription = c.DeviceDescription,
                    DeviceAddress = c.DeviceAddress,
                }).ToList());
            Scanner = new ObservableCollection<Scanner>(dataRepositories.VisaComDeviceRepository.Scanner
                .Select(c => new Scanner
                {
                    DeviceId = c.DeviceId,
                    DeviceName = c.DeviceName,
                    DeviceDescription = c.DeviceDescription,
                    DeviceAddress = c.DeviceAddress,
                }).ToList());   
        }
    }
}
