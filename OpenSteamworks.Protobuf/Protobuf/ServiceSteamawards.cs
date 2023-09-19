// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: service_steamawards.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OpenSteamworks.Protobuf.WebUI {

  /// <summary>Holder for reflection information generated from service_steamawards.proto</summary>
  public static partial class ServiceSteamawardsReflection {

    #region Descriptor
    /// <summary>File descriptor for service_steamawards.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ServiceSteamawardsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlzZXJ2aWNlX3N0ZWFtYXdhcmRzLnByb3RvGiBnb29nbGUvcHJvdG9idWYv",
            "ZGVzY3JpcHRvci5wcm90bxoRY29tbW9uX2Jhc2UucHJvdG8iWAooQ1N0ZWFt",
            "QXdhcmRzX0dldFVzZXJOb21pbmF0aW9uc19SZXNwb25zZRIsCgtub21pbmF0",
            "aW9ucxgBIAMoCzIXLkNTdGVhbUF3YXJkc05vbWluYXRpb24ilQEKFkNTdGVh",
            "bUF3YXJkc05vbWluYXRpb24SEwoLY2F0ZWdvcnlfaWQYASABKA0SFQoNY2F0",
            "ZWdvcnlfbmFtZRgCIAEoCRINCgVhcHBpZBgDIAEoDRIVCg13cml0ZV9pbl9u",
            "YW1lGAQgASgJEhMKC3N0b3JlX2FwcGlkGAUgASgNEhQKDGRldmVsb3Blcl9p",
            "ZBgGIAEoDTJfCgtTdGVhbUF3YXJkcxJQChJHZXRVc2VyTm9taW5hdGlvbnMS",
            "Dy5Ob3RJbXBsZW1lbnRlZBopLkNTdGVhbUF3YXJkc19HZXRVc2VyTm9taW5h",
            "dGlvbnNfUmVzcG9uc2VCIKoCHU9wZW5TdGVhbXdvcmtzLlByb3RvYnVmLldl",
            "YlVJ"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.Reflection.DescriptorReflection.Descriptor, global::OpenSteamworks.Protobuf.WebUI.CommonBaseReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OpenSteamworks.Protobuf.WebUI.CSteamAwards_GetUserNominations_Response), global::OpenSteamworks.Protobuf.WebUI.CSteamAwards_GetUserNominations_Response.Parser, new[]{ "Nominations" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::OpenSteamworks.Protobuf.WebUI.CSteamAwardsNomination), global::OpenSteamworks.Protobuf.WebUI.CSteamAwardsNomination.Parser, new[]{ "CategoryId", "CategoryName", "Appid", "WriteInName", "StoreAppid", "DeveloperId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CSteamAwards_GetUserNominations_Response : pb::IMessage<CSteamAwards_GetUserNominations_Response>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CSteamAwards_GetUserNominations_Response> _parser = new pb::MessageParser<CSteamAwards_GetUserNominations_Response>(() => new CSteamAwards_GetUserNominations_Response());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CSteamAwards_GetUserNominations_Response> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OpenSteamworks.Protobuf.WebUI.ServiceSteamawardsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CSteamAwards_GetUserNominations_Response() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CSteamAwards_GetUserNominations_Response(CSteamAwards_GetUserNominations_Response other) : this() {
      nominations_ = other.nominations_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CSteamAwards_GetUserNominations_Response Clone() {
      return new CSteamAwards_GetUserNominations_Response(this);
    }

    /// <summary>Field number for the "nominations" field.</summary>
    public const int NominationsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::OpenSteamworks.Protobuf.WebUI.CSteamAwardsNomination> _repeated_nominations_codec
        = pb::FieldCodec.ForMessage(10, global::OpenSteamworks.Protobuf.WebUI.CSteamAwardsNomination.Parser);
    private readonly pbc::RepeatedField<global::OpenSteamworks.Protobuf.WebUI.CSteamAwardsNomination> nominations_ = new pbc::RepeatedField<global::OpenSteamworks.Protobuf.WebUI.CSteamAwardsNomination>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::OpenSteamworks.Protobuf.WebUI.CSteamAwardsNomination> Nominations {
      get { return nominations_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CSteamAwards_GetUserNominations_Response);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CSteamAwards_GetUserNominations_Response other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!nominations_.Equals(other.nominations_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= nominations_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      nominations_.WriteTo(output, _repeated_nominations_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      nominations_.WriteTo(ref output, _repeated_nominations_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += nominations_.CalculateSize(_repeated_nominations_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CSteamAwards_GetUserNominations_Response other) {
      if (other == null) {
        return;
      }
      nominations_.Add(other.nominations_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            nominations_.AddEntriesFrom(input, _repeated_nominations_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            nominations_.AddEntriesFrom(ref input, _repeated_nominations_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class CSteamAwardsNomination : pb::IMessage<CSteamAwardsNomination>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CSteamAwardsNomination> _parser = new pb::MessageParser<CSteamAwardsNomination>(() => new CSteamAwardsNomination());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CSteamAwardsNomination> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OpenSteamworks.Protobuf.WebUI.ServiceSteamawardsReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CSteamAwardsNomination() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CSteamAwardsNomination(CSteamAwardsNomination other) : this() {
      _hasBits0 = other._hasBits0;
      categoryId_ = other.categoryId_;
      categoryName_ = other.categoryName_;
      appid_ = other.appid_;
      writeInName_ = other.writeInName_;
      storeAppid_ = other.storeAppid_;
      developerId_ = other.developerId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CSteamAwardsNomination Clone() {
      return new CSteamAwardsNomination(this);
    }

    /// <summary>Field number for the "category_id" field.</summary>
    public const int CategoryIdFieldNumber = 1;
    private readonly static uint CategoryIdDefaultValue = 0;

    private uint categoryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CategoryId {
      get { if ((_hasBits0 & 1) != 0) { return categoryId_; } else { return CategoryIdDefaultValue; } }
      set {
        _hasBits0 |= 1;
        categoryId_ = value;
      }
    }
    /// <summary>Gets whether the "category_id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasCategoryId {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "category_id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearCategoryId() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "category_name" field.</summary>
    public const int CategoryNameFieldNumber = 2;
    private readonly static string CategoryNameDefaultValue = "";

    private string categoryName_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string CategoryName {
      get { return categoryName_ ?? CategoryNameDefaultValue; }
      set {
        categoryName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "category_name" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasCategoryName {
      get { return categoryName_ != null; }
    }
    /// <summary>Clears the value of the "category_name" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearCategoryName() {
      categoryName_ = null;
    }

    /// <summary>Field number for the "appid" field.</summary>
    public const int AppidFieldNumber = 3;
    private readonly static uint AppidDefaultValue = 0;

    private uint appid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Appid {
      get { if ((_hasBits0 & 2) != 0) { return appid_; } else { return AppidDefaultValue; } }
      set {
        _hasBits0 |= 2;
        appid_ = value;
      }
    }
    /// <summary>Gets whether the "appid" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasAppid {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "appid" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearAppid() {
      _hasBits0 &= ~2;
    }

    /// <summary>Field number for the "write_in_name" field.</summary>
    public const int WriteInNameFieldNumber = 4;
    private readonly static string WriteInNameDefaultValue = "";

    private string writeInName_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string WriteInName {
      get { return writeInName_ ?? WriteInNameDefaultValue; }
      set {
        writeInName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "write_in_name" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasWriteInName {
      get { return writeInName_ != null; }
    }
    /// <summary>Clears the value of the "write_in_name" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearWriteInName() {
      writeInName_ = null;
    }

    /// <summary>Field number for the "store_appid" field.</summary>
    public const int StoreAppidFieldNumber = 5;
    private readonly static uint StoreAppidDefaultValue = 0;

    private uint storeAppid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StoreAppid {
      get { if ((_hasBits0 & 4) != 0) { return storeAppid_; } else { return StoreAppidDefaultValue; } }
      set {
        _hasBits0 |= 4;
        storeAppid_ = value;
      }
    }
    /// <summary>Gets whether the "store_appid" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasStoreAppid {
      get { return (_hasBits0 & 4) != 0; }
    }
    /// <summary>Clears the value of the "store_appid" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearStoreAppid() {
      _hasBits0 &= ~4;
    }

    /// <summary>Field number for the "developer_id" field.</summary>
    public const int DeveloperIdFieldNumber = 6;
    private readonly static uint DeveloperIdDefaultValue = 0;

    private uint developerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DeveloperId {
      get { if ((_hasBits0 & 8) != 0) { return developerId_; } else { return DeveloperIdDefaultValue; } }
      set {
        _hasBits0 |= 8;
        developerId_ = value;
      }
    }
    /// <summary>Gets whether the "developer_id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasDeveloperId {
      get { return (_hasBits0 & 8) != 0; }
    }
    /// <summary>Clears the value of the "developer_id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearDeveloperId() {
      _hasBits0 &= ~8;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CSteamAwardsNomination);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CSteamAwardsNomination other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CategoryId != other.CategoryId) return false;
      if (CategoryName != other.CategoryName) return false;
      if (Appid != other.Appid) return false;
      if (WriteInName != other.WriteInName) return false;
      if (StoreAppid != other.StoreAppid) return false;
      if (DeveloperId != other.DeveloperId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasCategoryId) hash ^= CategoryId.GetHashCode();
      if (HasCategoryName) hash ^= CategoryName.GetHashCode();
      if (HasAppid) hash ^= Appid.GetHashCode();
      if (HasWriteInName) hash ^= WriteInName.GetHashCode();
      if (HasStoreAppid) hash ^= StoreAppid.GetHashCode();
      if (HasDeveloperId) hash ^= DeveloperId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (HasCategoryId) {
        output.WriteRawTag(8);
        output.WriteUInt32(CategoryId);
      }
      if (HasCategoryName) {
        output.WriteRawTag(18);
        output.WriteString(CategoryName);
      }
      if (HasAppid) {
        output.WriteRawTag(24);
        output.WriteUInt32(Appid);
      }
      if (HasWriteInName) {
        output.WriteRawTag(34);
        output.WriteString(WriteInName);
      }
      if (HasStoreAppid) {
        output.WriteRawTag(40);
        output.WriteUInt32(StoreAppid);
      }
      if (HasDeveloperId) {
        output.WriteRawTag(48);
        output.WriteUInt32(DeveloperId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (HasCategoryId) {
        output.WriteRawTag(8);
        output.WriteUInt32(CategoryId);
      }
      if (HasCategoryName) {
        output.WriteRawTag(18);
        output.WriteString(CategoryName);
      }
      if (HasAppid) {
        output.WriteRawTag(24);
        output.WriteUInt32(Appid);
      }
      if (HasWriteInName) {
        output.WriteRawTag(34);
        output.WriteString(WriteInName);
      }
      if (HasStoreAppid) {
        output.WriteRawTag(40);
        output.WriteUInt32(StoreAppid);
      }
      if (HasDeveloperId) {
        output.WriteRawTag(48);
        output.WriteUInt32(DeveloperId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (HasCategoryId) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CategoryId);
      }
      if (HasCategoryName) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CategoryName);
      }
      if (HasAppid) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Appid);
      }
      if (HasWriteInName) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(WriteInName);
      }
      if (HasStoreAppid) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StoreAppid);
      }
      if (HasDeveloperId) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DeveloperId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CSteamAwardsNomination other) {
      if (other == null) {
        return;
      }
      if (other.HasCategoryId) {
        CategoryId = other.CategoryId;
      }
      if (other.HasCategoryName) {
        CategoryName = other.CategoryName;
      }
      if (other.HasAppid) {
        Appid = other.Appid;
      }
      if (other.HasWriteInName) {
        WriteInName = other.WriteInName;
      }
      if (other.HasStoreAppid) {
        StoreAppid = other.StoreAppid;
      }
      if (other.HasDeveloperId) {
        DeveloperId = other.DeveloperId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            CategoryId = input.ReadUInt32();
            break;
          }
          case 18: {
            CategoryName = input.ReadString();
            break;
          }
          case 24: {
            Appid = input.ReadUInt32();
            break;
          }
          case 34: {
            WriteInName = input.ReadString();
            break;
          }
          case 40: {
            StoreAppid = input.ReadUInt32();
            break;
          }
          case 48: {
            DeveloperId = input.ReadUInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            CategoryId = input.ReadUInt32();
            break;
          }
          case 18: {
            CategoryName = input.ReadString();
            break;
          }
          case 24: {
            Appid = input.ReadUInt32();
            break;
          }
          case 34: {
            WriteInName = input.ReadString();
            break;
          }
          case 40: {
            StoreAppid = input.ReadUInt32();
            break;
          }
          case 48: {
            DeveloperId = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code