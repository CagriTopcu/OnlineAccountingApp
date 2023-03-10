﻿using OnlineAccountingAppServer.Application.Messaging;

namespace OnlineAccountingAppServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.RemoveMainRole;

public sealed record RemoveByIdMainRoleCommand(
    string Id) : ICommand<RemoveByIdMainRoleCommandResponse>;
