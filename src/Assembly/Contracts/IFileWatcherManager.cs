/*
 *
 * Copyright (c) 2022-2024 Carbon Community
 * All rights reserved.
 *
 */

namespace API.Assembly;

public interface IFileWatcherManager
{
	public void Watch(WatchFolder item);
	public void Unwatch(string directory);
}
