using OpenSteamworks.KeyValues;

namespace OpenSteamworks.Client.Apps.Assets;

public class LibraryAssetsFile : TypedKVObject
{
    public class LibraryAsset : TypedKVObject
    {
        public LibraryAsset(KVObject kv) : base(kv) {
            if (!kv.HasChild("v")) {
                Version = 3;
            }
            
            if (!kv.HasChild("change")) {
                LastChangeNumber = 0;
            }
            
            if (!kv.HasChild("store_mtime")) {
                StoreAssetsLastModified = 0;
            }
        }

        public int LastChangeNumber {
            get => DefaultIfUnset("change", 0);
            set => SetValue("change", value);
        }

        //NOTE: OpenSteam custom key, unused by ValveSteam.
        public long StoreAssetsLastModified {
            get => DefaultIfUnset("store_mtime", 0L);
            set => SetValue("store_mtime", value);
        }

        public int Version {
            get => DefaultIfUnset("v", 3);
            set => SetValue("v", value);
        }

        public string IconHash {
            get => DefaultIfUnset("icon", "");
            set => SetValue("icon", value);
        }

        public string PortraitLastModified {
            get => DefaultIfUnset("0x", "");
            set => SetValue("0x", value);
        }

        public long PortraitExpires {
            get => DefaultIfUnset("0", 0L);
            set => SetValue("0", value);
        }

        public string HeroLastModified {
            get => DefaultIfUnset("1x", "");
            set => SetValue("1x", value);
        }

        public long HeroExpires {
            get => DefaultIfUnset("1", 0L);
            set => SetValue("1", value);
        }

        public string LogoLastModified {
            get => DefaultIfUnset("2x", "");
            set => SetValue("2x", value);
        }

        public long LogoExpires {
            get => DefaultIfUnset("2", 0L);
            set => SetValue("2", value);
        }

        public string HeaderLastModified {
            get => DefaultIfUnset("3x", "");
            set => SetValue("3x", value);
        }

        public long HeaderExpires {
            get => DefaultIfUnset("3", 0L);
            set => SetValue("3", value);
        }

        public string HeroCapsuleLastModified {
            get => DefaultIfUnset("5x", "");
            set => SetValue("5x", value);
        }

        public long HeroCapsuleExpires {
            get => DefaultIfUnset("5", 0L);
            set => SetValue("5", value);
        }

        public void SetLastModified(string lastModified, AppsManager.ELibraryAssetType assetType)
        {
            switch (assetType)
            {
                case AppsManager.ELibraryAssetType.Icon:
                    break;

                case AppsManager.ELibraryAssetType.Logo:
                    LogoLastModified = lastModified;
                    break;
                case AppsManager.ELibraryAssetType.Hero:
                    HeroLastModified = lastModified;
                    break;
                case AppsManager.ELibraryAssetType.Portrait:
                    PortraitLastModified = lastModified;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(assetType));
            }
        }

        public void SetExpires(long expires, AppsManager.ELibraryAssetType assetType)
        {
            switch (assetType)
            {
                case AppsManager.ELibraryAssetType.Icon:
                    break;

                case AppsManager.ELibraryAssetType.Logo:
                    LogoExpires = expires;
                    break;
                case AppsManager.ELibraryAssetType.Hero:
                    HeroExpires = expires;
                    break;
                case AppsManager.ELibraryAssetType.Portrait:
                    PortraitExpires = expires;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(assetType));
            }
        }

        public string GetLastModified(AppsManager.ELibraryAssetType assetType)
        {
            return assetType switch
            {
                AppsManager.ELibraryAssetType.Icon => "",
                AppsManager.ELibraryAssetType.Logo => LogoLastModified,
                AppsManager.ELibraryAssetType.Hero => HeroLastModified,
                AppsManager.ELibraryAssetType.Portrait => PortraitLastModified,
                _ => throw new ArgumentOutOfRangeException(nameof(assetType)),
            };
        }

        public long GetExpires(AppsManager.ELibraryAssetType assetType)
        {
            return assetType switch
            {
                AppsManager.ELibraryAssetType.Icon => 0,
                AppsManager.ELibraryAssetType.Logo => LogoExpires,
                AppsManager.ELibraryAssetType.Hero => HeroExpires,
                AppsManager.ELibraryAssetType.Portrait => PortraitExpires,
                _ => throw new ArgumentOutOfRangeException(nameof(assetType)),
            };
        }
    }

    public LibraryAssetsFile(KVObject kv) : base(kv) { }
    public Dictionary<string, LibraryAsset> Assets {
        get => EmptyDictionaryIfUnset("0", kv => new LibraryAsset(kv));
        set => SetValue("0", value);
    }

    public Dictionary<string, LibraryAsset> Assets2 {
        get => EmptyDictionaryIfUnset("15", kv => new LibraryAsset(kv));
        set => SetValue("15", value);
    }
}