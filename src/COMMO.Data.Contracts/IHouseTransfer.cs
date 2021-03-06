﻿// <copyright file="IHouseTransfer.cs" company="2Dudes">
// Copyright (c) 2018 2Dudes. All rights reserved.
// Licensed under the MIT license.
// See LICENSE file in the project root for full license information.
// </copyright>

namespace COMMO.Data.Contracts
{
    public interface IHouseTransfer
    {
        long Id { get; set; }

        short HouseId { get; set; }

        int TransferTo { get; set; }

        long Gold { get; set; }

        byte Done { get; set; }
    }
}
