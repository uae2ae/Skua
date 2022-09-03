﻿using CommunityToolkit.Mvvm.Messaging.Messages;
using Skua.Core.Models.GitHub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skua.Core.Messaging;
public sealed record CheckClientUpdateMessage();
public sealed record DownloadClientUpdateMessage(UpdateInfo UpdateInfo);
public sealed record UpdateScriptsMessage(bool Reset);
public sealed class UpdateStartedMessage : AsyncRequestMessage<bool> { }
public sealed record UpdateFinishedMessage();
