// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine.SocialPlatforms
public interface ISocialPlatform
{
	// Methods

	// RVA: -1
	public abstract Void Authenticate(ILocalUser user, Action<T0> callback) { }

	// RVA: -1
	public abstract Void Authenticate(ILocalUser user, Action<T0, T1> callback) { }

	// RVA: -1
	public abstract Void LoadFriends(ILocalUser user, Action<T0> callback) { }

}

// Namespace: UnityEngine.SocialPlatforms
public interface ILocalUser
{
	// Properties
	public abstract Boolean authenticated { get; }

	// Methods

	// RVA: -1
	public abstract Boolean get_authenticated() { }

}

// Namespace: UnityEngine.SocialPlatforms
public enum UserState
{
	// Fields
	public Int32 value__; // 0x10
	public const UserState Online = 0;
	public const UserState OnlineAndAway = 1;
	public const UserState OnlineAndBusy = 2;
	public const UserState Offline = 3;
	public const UserState Playing = 4;
}

// Namespace: UnityEngine.SocialPlatforms
public interface IUserProfile
{}

// Namespace: UnityEngine.SocialPlatforms
public interface IAchievement
{}

// Namespace: UnityEngine.SocialPlatforms
public interface IAchievementDescription
{}

// Namespace: UnityEngine.SocialPlatforms
public interface IScore
{}

// Namespace: UnityEngine.SocialPlatforms
public enum UserScope
{
	// Fields
	public Int32 value__; // 0x10
	public const UserScope Global = 0;
	public const UserScope FriendsOnly = 1;
}

// Namespace: UnityEngine.SocialPlatforms
public enum TimeScope
{
	// Fields
	public Int32 value__; // 0x10
	public const TimeScope Today = 0;
	public const TimeScope Week = 1;
	public const TimeScope AllTime = 2;
}

// Namespace: UnityEngine.SocialPlatforms
public struct Range
{
	// Fields
	public Int32 from; // 0x10
	public Int32 count; // 0x14

	// Methods

	// RVA: 0xFFFFFFFF7114F34C
	public Void .ctor(Int32 fromValue, Int32 valueCount) { }

}

// Namespace: UnityEngine.SocialPlatforms
public interface ILeaderboard
{
	// Properties
	public abstract String id { get; }
	public abstract UserScope userScope { get; }
	public abstract Range range { get; }
	public abstract TimeScope timeScope { get; }

	// Methods

	// RVA: -1
	public abstract String get_id() { }

	// RVA: -1
	public abstract UserScope get_userScope() { }

	// RVA: -1
	public abstract Range get_range() { }

	// RVA: -1
	public abstract TimeScope get_timeScope() { }

}

// Namespace: UnityEngine.SocialPlatforms.Impl
public class LocalUser
{
	// Fields
	private IUserProfile[] m_Friends; // 0x40
	private Boolean m_Authenticated; // 0x48
	private Boolean m_Underage; // 0x49

	// Properties
	public Boolean authenticated { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C4A638
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C49D00
	public Void SetFriends(IUserProfile[] friends) { }

	// RVA: 0xFFFFFFFF75C4A6DC
	public Void SetAuthenticated(Boolean value) { }

	// RVA: 0xFFFFFFFF75C4A808
	public Void SetUnderage(Boolean value) { }

	// RVA: 0xFFFFFFFF75C4CDF0
	public Boolean get_authenticated() { }

}

// Namespace: UnityEngine.SocialPlatforms.Impl
public class UserProfile
{
	// Fields
	protected String m_UserName; // 0x10
	protected String m_ID; // 0x18
	private String m_legacyID; // 0x20
	protected Boolean m_IsFriend; // 0x28
	protected UserState m_State; // 0x2C
	protected Texture2D m_Image; // 0x30
	private String m_gameID; // 0x38

	// Properties
	public String userName { get; }
	public String id { get; }
	public Boolean isFriend { get; }
	public UserState state { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C4CD38
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C4C550
	public Void .ctor(String name, String teamId, String gameId, Boolean friend, UserState state, Texture2D image) { }

	// RVA: 0xFFFFFFFF75C4CFA4
	public override String ToString() { }

	// RVA: 0xFFFFFFFF75C4A718
	public Void SetUserName(String name) { }

	// RVA: 0xFFFFFFFF75C4A754
	public Void SetUserID(String id) { }

	// RVA: 0xFFFFFFFF75C4A7CC
	public Void SetLegacyUserID(String id) { }

	// RVA: 0xFFFFFFFF75C4A790
	public Void SetUserGameID(String id) { }

	// RVA: 0xFFFFFFFF75C4A844
	public Void SetImage(Texture2D image) { }

	// RVA: 0xFFFFFFFF75C4D0B8
	public String get_userName() { }

	// RVA: 0xFFFFFFFF75C4A6D4
	public String get_id() { }

	// RVA: 0xFFFFFFFF75C4D0C0
	public Boolean get_isFriend() { }

	// RVA: 0xFFFFFFFF75C4D0C8
	public UserState get_state() { }

}

// Namespace: UnityEngine.SocialPlatforms.Impl
public class Achievement
{
	// Fields
	private Boolean m_Completed; // 0x10
	private Boolean m_Hidden; // 0x11
	private DateTime m_LastReportedDate; // 0x18
	private String <id>k__BackingField; // 0x20
	private Double <percentCompleted>k__BackingField; // 0x28

	// Properties
	public String id { get; set; }
	public Double percentCompleted { get; set; }
	public Boolean completed { get; }
	public Boolean hidden { get; }
	public DateTime lastReportedDate { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C4BF70
	public Void .ctor(String id, Double percentCompleted, Boolean completed, Boolean hidden, DateTime lastReportedDate) { }

	// RVA: 0xFFFFFFFF75C4C5E8
	public Void .ctor(String id, Double percent) { }

	// RVA: 0xFFFFFFFF75C4BB60
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C4C66C
	public override String ToString() { }

	// RVA: 0xFFFFFFFF75C4C7D8
	public String get_id() { }

	// RVA: 0xFFFFFFFF75C4C7E0
	public Void set_id(String value) { }

	// RVA: 0xFFFFFFFF75C4C7E8
	public Double get_percentCompleted() { }

	// RVA: 0xFFFFFFFF75C4C7F0
	public Void set_percentCompleted(Double value) { }

	// RVA: 0xFFFFFFFF75C4C7C0
	public Boolean get_completed() { }

	// RVA: 0xFFFFFFFF75C4C7C8
	public Boolean get_hidden() { }

	// RVA: 0xFFFFFFFF75C4C7D0
	public DateTime get_lastReportedDate() { }

}

// Namespace: UnityEngine.SocialPlatforms.Impl
public class AchievementDescription
{
	// Fields
	private String m_Title; // 0x10
	private Texture2D m_Image; // 0x18
	private String m_AchievedDescription; // 0x20
	private String m_UnachievedDescription; // 0x28
	private Boolean m_Hidden; // 0x30
	private Int32 m_Points; // 0x34
	private String <id>k__BackingField; // 0x38

	// Properties
	public String id { get; set; }
	public String title { get; }
	public String achievedDescription { get; }
	public String unachievedDescription { get; }
	public Boolean hidden { get; }
	public Int32 points { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C4BFE0
	public Void .ctor(String id, String title, Texture2D image, String achievedDescription, String unachievedDescription, Boolean hidden, Int32 points) { }

	// RVA: 0xFFFFFFFF75C4C7F8
	public override String ToString() { }

	// RVA: 0xFFFFFFFF75C494DC
	public Void SetImage(Texture2D image) { }

	// RVA: 0xFFFFFFFF75C4C968
	public String get_id() { }

	// RVA: 0xFFFFFFFF75C4C970
	public Void set_id(String value) { }

	// RVA: 0xFFFFFFFF75C4C940
	public String get_title() { }

	// RVA: 0xFFFFFFFF75C4C948
	public String get_achievedDescription() { }

	// RVA: 0xFFFFFFFF75C4C950
	public String get_unachievedDescription() { }

	// RVA: 0xFFFFFFFF75C4C960
	public Boolean get_hidden() { }

	// RVA: 0xFFFFFFFF75C4C958
	public Int32 get_points() { }

}

// Namespace: UnityEngine.SocialPlatforms.Impl
public class Score
{
	// Fields
	private DateTime m_Date; // 0x10
	private String m_FormattedValue; // 0x18
	private String m_UserID; // 0x20
	private Int32 m_Rank; // 0x28
	private String <leaderboardID>k__BackingField; // 0x30
	private Int64 <value>k__BackingField; // 0x38

	// Properties
	public String leaderboardID { get; set; }
	public Int64 value { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75C4C980
	public Void .ctor(String leaderboardID, Int64 value) { }

	// RVA: 0xFFFFFFFF75C4C42C
	public Void .ctor(String leaderboardID, Int64 value, String userID, DateTime date, String formattedValue, Int32 rank) { }

	// RVA: 0xFFFFFFFF75C4CDF8
	public override String ToString() { }

	// RVA: 0xFFFFFFFF75C4CF84
	public String get_leaderboardID() { }

	// RVA: 0xFFFFFFFF75C4CF8C
	public Void set_leaderboardID(String value) { }

	// RVA: 0xFFFFFFFF75C4CF94
	public Int64 get_value() { }

	// RVA: 0xFFFFFFFF75C4CF9C
	public Void set_value(Int64 value) { }

}

// Namespace: UnityEngine.SocialPlatforms.Impl
public class Leaderboard
{
	// Fields
	private Boolean m_Loading; // 0x10
	private IScore m_LocalUserScore; // 0x18
	private UInt32 m_MaxRange; // 0x20
	private IScore[] m_Scores; // 0x28
	private String m_Title; // 0x30
	private String[] m_UserIDs; // 0x38
	private String <id>k__BackingField; // 0x40
	private UserScope <userScope>k__BackingField; // 0x48
	private Range <range>k__BackingField; // 0x4C
	private TimeScope <timeScope>k__BackingField; // 0x54

	// Properties
	public String id { get; set; }
	public UserScope userScope { get; set; }
	public Range range { get; set; }
	public TimeScope timeScope { get; set; }

	// Methods

	// RVA: 0xFFFFFFFF75C4B9F0
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C4C9F4
	public override String ToString() { }

	// RVA: 0xFFFFFFFF75C4C2D8
	public Void SetLocalUserScore(IScore score) { }

	// RVA: 0xFFFFFFFF75C4C2F0
	public Void SetMaxRange(UInt32 maxRange) { }

	// RVA: 0xFFFFFFFF75C4C290
	public Void SetScores(IScore[] scores) { }

	// RVA: 0xFFFFFFFF75C4C30C
	public Void SetTitle(String title) { }

	// RVA: 0xFFFFFFFF75C4B21C
	public String[] GetUserFilter() { }

	// RVA: 0xFFFFFFFF75C4CCF8
	public String get_id() { }

	// RVA: 0xFFFFFFFF75C4CD00
	public Void set_id(String value) { }

	// RVA: 0xFFFFFFFF75C4CD08
	public UserScope get_userScope() { }

	// RVA: 0xFFFFFFFF75C4CD10
	public Void set_userScope(UserScope value) { }

	// RVA: 0xFFFFFFFF75C4CD18
	public Range get_range() { }

	// RVA: 0xFFFFFFFF75C4CD20
	public Void set_range(Range value) { }

	// RVA: 0xFFFFFFFF75C4CD28
	public TimeScope get_timeScope() { }

	// RVA: 0xFFFFFFFF75C4CD30
	public Void set_timeScope(TimeScope value) { }

}

// Namespace: UnityEngine.SocialPlatforms.GameCenter
internal struct GcUserProfileData
{
	// Fields
	public String userName; // 0x10
	public String teamID; // 0x18
	public String gameID; // 0x20
	public Int32 isFriend; // 0x28
	public Texture2D image; // 0x30

	// Methods

	// RVA: 0xFFFFFFFF7114F33C
	public UserProfile ToUserProfile() { }

	// RVA: 0xFFFFFFFF7114F344
	public Void AddToArray(ref UserProfile[] array, Int32 number) { }

}

// Namespace: UnityEngine.SocialPlatforms.GameCenter
internal struct GcAchievementDescriptionData
{
	// Fields
	public String m_Identifier; // 0x10
	public String m_Title; // 0x18
	public Texture2D m_Image; // 0x20
	public String m_AchievedDescription; // 0x28
	public String m_UnachievedDescription; // 0x30
	public Int32 m_Hidden; // 0x38
	public Int32 m_Points; // 0x3C

	// Methods

	// RVA: 0xFFFFFFFF7114F198
	public AchievementDescription ToAchievementDescription() { }

}

// Namespace: UnityEngine.SocialPlatforms.GameCenter
internal struct GcAchievementData
{
	// Fields
	public String m_Identifier; // 0x10
	public Double m_PercentCompleted; // 0x18
	public Int32 m_Completed; // 0x20
	public Int32 m_Hidden; // 0x24
	public Int32 m_LastReportedDate; // 0x28

	// Methods

	// RVA: 0xFFFFFFFF7114F154
	public Achievement ToAchievement() { }

}

// Namespace: UnityEngine.SocialPlatforms.GameCenter
internal struct GcScoreData
{
	// Fields
	public String m_Category; // 0x10
	public UInt32 m_ValueLow; // 0x18
	public Int32 m_ValueHigh; // 0x1C
	public Int32 m_Date; // 0x20
	public String m_FormattedValue; // 0x28
	public String m_PlayerID; // 0x30
	public Int32 m_Rank; // 0x38

	// Methods

	// RVA: 0xFFFFFFFF7114F2F8
	public Score ToScore() { }

}

// Namespace: UnityEngine.SocialPlatforms.GameCenter
public class GameCenterPlatform
{
	// Fields
	private static Action<T0, T1> s_AuthenticateCallback; // 0x0
	private static AchievementDescription[] s_adCache; // 0x8
	private static UserProfile[] s_friends; // 0x10
	private static UserProfile[] s_users; // 0x18
	private static Action<T0> s_ResetAchievements; // 0x20
	private static LocalUser m_LocalUser; // 0x28
	private static List<T0> m_GcBoards; // 0x30

	// Properties
	public ILocalUser localUser { get; }

	// Methods

	// RVA: 0xFFFFFFFF75C49204
	private static Void ClearAchievementDescriptions(Int32 size) { }

	// RVA: 0xFFFFFFFF75C492B0
	private static Void SetAchievementDescription(GcAchievementDescriptionData data, Int32 number) { }

	// RVA: 0xFFFFFFFF75C493FC
	private static Void SetAchievementDescriptionImage(Texture2D texture, Int32 number) { }

	// RVA: 0xFFFFFFFF75C494E4
	private static Void TriggerAchievementDescriptionCallback(Action<T0> callback) { }

	// RVA: 0xFFFFFFFF75C495EC
	private static Void AuthenticateCallbackWrapper(Int32 result, String error) { }

	// RVA: 0xFFFFFFFF75C49888
	private static Void ClearFriends(Int32 size) { }

	// RVA: 0xFFFFFFFF75C49978
	private static Void SetFriends(GcUserProfileData data, Int32 number) { }

	// RVA: 0xFFFFFFFF75C49ABC
	private static Void SetFriendImage(Texture2D texture, Int32 number) { }

	// RVA: 0xFFFFFFFF75C49C50
	private static Void TriggerFriendsCallbackWrapper(Action<T0> callback, Int32 result) { }

	// RVA: 0xFFFFFFFF75C49D08
	private static Void AchievementCallbackWrapper(Action<T0> callback, GcAchievementData[] result) { }

	// RVA: 0xFFFFFFFF75C49F5C
	private static Void ProgressCallbackWrapper(Action<T0> callback, Boolean success) { }

	// RVA: 0xFFFFFFFF75C49F70
	private static Void ScoreCallbackWrapper(Action<T0> callback, Boolean success) { }

	// RVA: 0xFFFFFFFF75C49F84
	private static Void ScoreLoaderCallbackWrapper(Action<T0> callback, GcScoreData[] result) { }

	// RVA: 0xFFFFFFFF75C4A17C
	private Void UnityEngine.SocialPlatforms.ISocialPlatform.LoadFriends(ILocalUser user, Action<T0> callback) { }

	// RVA: 0xFFFFFFFF75C4A358
	private Void UnityEngine.SocialPlatforms.ISocialPlatform.Authenticate(ILocalUser user, Action<T0> callback) { }

	// RVA: 0xFFFFFFFF75C4A47C
	private Void UnityEngine.SocialPlatforms.ISocialPlatform.Authenticate(ILocalUser user, Action<T0, T1> callback) { }

	// RVA: 0xFFFFFFFF75C4A538
	public ILocalUser get_localUser() { }

	// RVA: 0xFFFFFFFF75C4969C
	private static Void PopulateLocalUser() { }

	// RVA: 0xFFFFFFFF75C4A84C
	public Void LoadAchievementDescriptions(Action<T0> callback) { }

	// RVA: 0xFFFFFFFF75C4A964
	public Void ReportProgress(String id, Double progress, Action<T0> callback) { }

	// RVA: 0xFFFFFFFF75C4AAA4
	public Void LoadAchievements(Action<T0> callback) { }

	// RVA: 0xFFFFFFFF75C4ABBC
	public Void ReportScore(Int64 score, String board, Action<T0> callback) { }

	// RVA: 0xFFFFFFFF75C4ACE4
	public Void LoadScores(String category, Action<T0> callback) { }

	// RVA: 0xFFFFFFFF75C4AE24
	public Void LoadScores(ILeaderboard board, Action<T0> callback) { }

	// RVA: 0xFFFFFFFF75C4B2C4
	private static Void LeaderboardCallbackWrapper(Action<T0> callback, Boolean success) { }

	// RVA: 0xFFFFFFFF75C4B2D8
	public Boolean GetLoading(ILeaderboard board) { }

	// RVA: 0xFFFFFFFF75C4A22C
	private Boolean VerifyAuthentication() { }

	// RVA: 0xFFFFFFFF75C4B50C
	public Void ShowAchievementsUI() { }

	// RVA: 0xFFFFFFFF75C4B5C4
	public Void ShowLeaderboardUI() { }

	// RVA: 0xFFFFFFFF75C4B67C
	private static Void ClearUsers(Int32 size) { }

	// RVA: 0xFFFFFFFF75C4B6E4
	private static Void SetUser(GcUserProfileData data, Int32 number) { }

	// RVA: 0xFFFFFFFF75C4B75C
	private static Void SetUserImage(Texture2D texture, Int32 number) { }

	// RVA: 0xFFFFFFFF75C4B7D4
	private static Void TriggerUsersCallbackWrapper(Action<T0> callback) { }

	// RVA: 0xFFFFFFFF75C4B860
	public Void LoadUsers(String[] userIds, Action<T0> callback) { }

	// RVA: 0xFFFFFFFF75C49B34
	private static Void SafeSetUserImage(ref UserProfile[] array, Texture2D texture, Int32 number) { }

	// RVA: 0xFFFFFFFF75C498F0
	private static Void SafeClearArray(ref UserProfile[] array, Int32 size) { }

	// RVA: 0xFFFFFFFF75C4B9A0
	public ILeaderboard CreateLeaderboard() { }

	// RVA: 0xFFFFFFFF75C4BB04
	public IAchievement CreateAchievement() { }

	// RVA: 0xFFFFFFFF75C4BB70
	private static Void TriggerResetAchievementCallback(Boolean result) { }

	// RVA: 0xFFFFFFFF75C4A504
	internal static Void Authenticate() { }

	// RVA: 0xFFFFFFFF75C4A6A0
	internal static Boolean GetAuthenticated() { }

	// RVA: 0xFFFFFFFF75C4A6E4
	internal static String Internal_UserName() { }

	// RVA: 0xFFFFFFFF75C4A720
	internal static String Internal_UserID() { }

	// RVA: 0xFFFFFFFF75C4A75C
	internal static String Internal_UserGameID() { }

	// RVA: 0xFFFFFFFF75C4A798
	internal static String Internal_LegacyUserID() { }

	// RVA: 0xFFFFFFFF75C4A7D4
	internal static Boolean GetIsUnderage() { }

	// RVA: 0xFFFFFFFF75C4A810
	internal static Texture2D GetUserImage() { }

	// RVA: 0xFFFFFFFF75C4A318
	internal static Void LoadFriends(Object callback) { }

	// RVA: 0xFFFFFFFF75C4A924
	internal static Void InternalLoadAchievementDescriptions(Object callback) { }

	// RVA: 0xFFFFFFFF75C4AB7C
	internal static Void InternalLoadAchievements(Object callback) { }

	// RVA: 0xFFFFFFFF75C4AA44
	internal static Void InternalReportProgress(String id, Double progress, Object callback) { }

	// RVA: 0xFFFFFFFF75C4AC8C
	internal static Void InternalReportScore(Int64 score, String category, Object callback) { }

	// RVA: 0xFFFFFFFF75C4ADD4
	internal static Void InternalLoadScores(String category, Object callback) { }

	// RVA: 0xFFFFFFFF75C4B590
	internal static Void Internal_ShowAchievementsUI() { }

	// RVA: 0xFFFFFFFF75C4B648
	internal static Void Internal_ShowLeaderboardUI() { }

	// RVA: 0xFFFFFFFF75C4B950
	internal static Void Internal_LoadUsers(String[] userIds, Object callback) { }

	// RVA: 0xFFFFFFFF75C4BBF0
	internal static Void ResetAllAchievements() { }

	// RVA: 0xFFFFFFFF75C4BC24
	internal static Void ShowDefaultAchievementBanner(Boolean value) { }

	// RVA: 0xFFFFFFFF75C4BC64
	public static Void ResetAllAchievements(Action<T0> callback) { }

	// RVA: 0xFFFFFFFF75C4BCEC
	public static Void ShowDefaultAchievementCompletionBanner(Boolean value) { }

	// RVA: 0xFFFFFFFF75C4BD68
	public static Void ShowLeaderboardUI(String leaderboardID, TimeScope timeScope) { }

	// RVA: 0xFFFFFFFF75C4BDF4
	internal static Void ShowSpecificLeaderboardUI(String leaderboardID, Int32 timeScope) { }

	// RVA: 0xFFFFFFFF75C4BE44
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C4BE4C
	private static Void .cctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass21_0
{
	// Fields
	public Action<T0> callback; // 0x10

	// Methods

	// RVA: 0xFFFFFFFF75C4A474
	public Void .ctor() { }

	// RVA: 0xFFFFFFFF75C4BF4C
	internal Void <UnityEngine.SocialPlatforms.ISocialPlatform.Authenticate>b__0(Boolean success, String error) { }

}

// Namespace: UnityEngine.SocialPlatforms.GameCenter
internal class GcLeaderboard
{
	// Fields
	private IntPtr m_InternalLeaderboard; // 0x10
	private Leaderboard m_GenericLeaderboard; // 0x18

	// Methods

	// RVA: 0xFFFFFFFF75C4B1E8
	internal Void .ctor(Leaderboard board) { }

	// RVA: 0xFFFFFFFF75C4C090
	protected override Void Finalize() { }

	// RVA: 0xFFFFFFFF75C4B4BC
	internal Boolean Contains(Leaderboard board) { }

	// RVA: 0xFFFFFFFF75C4C188
	internal Void SetScores(GcScoreData[] scoreDatas) { }

	// RVA: 0xFFFFFFFF75C4C298
	internal Void SetLocalScore(GcScoreData scoreData) { }

	// RVA: 0xFFFFFFFF75C4C2E0
	internal Void SetMaxRange(UInt32 maxRange) { }

	// RVA: 0xFFFFFFFF75C4C2F8
	internal Void SetTitle(String title) { }

	// RVA: 0xFFFFFFFF75C4B224
	internal Void Internal_LoadScores(String category, Int32 from, Int32 count, String[] userIDs, Int32 playerScope, Int32 timeScope, Object callback) { }

	// RVA: 0xFFFFFFFF75C4C314
	private static IntPtr GcLeaderboard_LoadScores(Object self, String category, Int32 from, Int32 count, String[] userIDs, Int32 playerScope, Int32 timeScope, Object callback) { }

	// RVA: 0xFFFFFFFF75C4B4CC
	internal Boolean Loading() { }

	// RVA: 0xFFFFFFFF75C4C3AC
	private static Boolean GcLeaderboard_Loading(IntPtr leaderboard) { }

	// RVA: 0xFFFFFFFF75C4C134
	internal Void Dispose() { }

	// RVA: 0xFFFFFFFF75C4C3EC
	private static Void GcLeaderboard_Dispose(IntPtr leaderboard) { }

}


