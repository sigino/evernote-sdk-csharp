/**
 * Autogenerated by Thrift Compiler (1.0.0-dev)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace Evernote.EDAM.Type
{

  /// <summary>
  /// Every media file that is embedded or attached to a note is represented
  /// through a Resource entry.
  /// <dl>
  /// <dt>guid</dt>
  ///   <dd>The unique identifier of this resource.  Will be set whenever
  ///   a resource is retrieved from the service, but may be null when a client
  ///   is creating a resource.
  ///   <br/>
  ///   Length:  EDAM_GUID_LEN_MIN - EDAM_GUID_LEN_MAX
  ///   <br/>
  ///   Regex:  EDAM_GUID_REGEX
  ///   </dd>
  /// 
  /// <dt>noteGuid</dt>
  ///   <dd>The unique identifier of the Note that holds this
  ///   Resource. Will be set whenever the resource is retrieved from the service,
  ///   but may be null when a client is creating a resource.
  ///   <br/>
  ///   Length:  EDAM_GUID_LEN_MIN - EDAM_GUID_LEN_MAX
  ///   <br/>
  ///   Regex:  EDAM_GUID_REGEX
  ///   </dd>
  /// 
  /// <dt>data</dt>
  ///   <dd>The contents of the resource.
  ///   Maximum length:  The data.body is limited to EDAM_RESOURCE_SIZE_MAX_FREE
  ///   for free accounts and EDAM_RESOURCE_SIZE_MAX_PREMIUM for premium accounts.
  ///   </dd>
  /// 
  /// <dt>mime</dt>
  ///   <dd>The MIME type for the embedded resource.  E.g. "image/gif"
  ///   <br/>
  ///   Length:  EDAM_MIME_LEN_MIN - EDAM_MIME_LEN_MAX
  ///   <br/>
  ///   Regex:  EDAM_MIME_REGEX
  ///   </dd>
  /// 
  /// <dt>width</dt>
  ///   <dd>If set, this contains the display width of this resource, in
  ///   pixels.
  ///   </dd>
  /// 
  /// <dt>height</dt>
  ///   <dd>If set, this contains the display height of this resource,
  ///   in pixels.
  ///   </dd>
  /// 
  /// <dt>duration</dt>
  ///   <dd>DEPRECATED: ignored.
  ///   </dd>
  /// 
  /// <dt>active</dt>
  ///   <dd>If the resource is active or not.
  ///   </dd>
  /// 
  /// <dt>recognition</dt>
  ///   <dd>If set, this will hold the encoded data that provides
  ///   information on search and recognition within this resource.
  ///   </dd>
  /// 
  /// <dt>attributes</dt>
  ///   <dd>A list of the attributes for this resource.
  ///   </dd>
  /// 
  /// <dt>updateSequenceNum</dt>
  ///   <dd>A number identifying the last transaction to
  ///   modify the state of this object. The USN values are sequential within an
  ///   account, and can be used to compare the order of modifications within the
  ///   service.
  ///   </dd>
  /// 
  /// <dt>alternateData</dt>
  ///   <dd>Some Resources may be assigned an alternate data format by the service
  ///   which may be more appropriate for indexing or rendering than the original
  ///   data provided by the user.  In these cases, the alternate data form will
  ///   be available via this Data element.  If a Resource has no alternate form,
  ///   this field will be unset.</dd>
  /// </dl>
  /// </summary>
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class Resource : TBase
  {
    private string _guid;
    private string _noteGuid;
    private Data _data;
    private string _mime;
    private short _width;
    private short _height;
    private short _duration;
    private bool _active;
    private Data _recognition;
    private ResourceAttributes _attributes;
    private int _updateSequenceNum;
    private Data _alternateData;

    public string Guid
    {
      get
      {
        return _guid;
      }
      set
      {
        __isset.guid = true;
        this._guid = value;
      }
    }

    public string NoteGuid
    {
      get
      {
        return _noteGuid;
      }
      set
      {
        __isset.noteGuid = true;
        this._noteGuid = value;
      }
    }

    public Data Data
    {
      get
      {
        return _data;
      }
      set
      {
        __isset.data = true;
        this._data = value;
      }
    }

    public string Mime
    {
      get
      {
        return _mime;
      }
      set
      {
        __isset.mime = true;
        this._mime = value;
      }
    }

    public short Width
    {
      get
      {
        return _width;
      }
      set
      {
        __isset.width = true;
        this._width = value;
      }
    }

    public short Height
    {
      get
      {
        return _height;
      }
      set
      {
        __isset.height = true;
        this._height = value;
      }
    }

    public short Duration
    {
      get
      {
        return _duration;
      }
      set
      {
        __isset.duration = true;
        this._duration = value;
      }
    }

    public bool Active
    {
      get
      {
        return _active;
      }
      set
      {
        __isset.active = true;
        this._active = value;
      }
    }

    public Data Recognition
    {
      get
      {
        return _recognition;
      }
      set
      {
        __isset.recognition = true;
        this._recognition = value;
      }
    }

    public ResourceAttributes Attributes
    {
      get
      {
        return _attributes;
      }
      set
      {
        __isset.attributes = true;
        this._attributes = value;
      }
    }

    public int UpdateSequenceNum
    {
      get
      {
        return _updateSequenceNum;
      }
      set
      {
        __isset.updateSequenceNum = true;
        this._updateSequenceNum = value;
      }
    }

    public Data AlternateData
    {
      get
      {
        return _alternateData;
      }
      set
      {
        __isset.alternateData = true;
        this._alternateData = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool guid;
      public bool noteGuid;
      public bool data;
      public bool mime;
      public bool width;
      public bool height;
      public bool duration;
      public bool active;
      public bool recognition;
      public bool attributes;
      public bool updateSequenceNum;
      public bool alternateData;
    }

    public Resource() {
    }

    public void Read (TProtocol iprot)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        iprot.ReadStructBegin();
        while (true)
        {
          field = iprot.ReadFieldBegin();
          if (field.Type == TType.Stop) { 
            break;
          }
          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.String) {
                Guid = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.String) {
                NoteGuid = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.Struct) {
                Data = new Data();
                Data.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.String) {
                Mime = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 5:
              if (field.Type == TType.I16) {
                Width = iprot.ReadI16();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 6:
              if (field.Type == TType.I16) {
                Height = iprot.ReadI16();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 7:
              if (field.Type == TType.I16) {
                Duration = iprot.ReadI16();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 8:
              if (field.Type == TType.Bool) {
                Active = iprot.ReadBool();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 9:
              if (field.Type == TType.Struct) {
                Recognition = new Data();
                Recognition.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 11:
              if (field.Type == TType.Struct) {
                Attributes = new ResourceAttributes();
                Attributes.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 12:
              if (field.Type == TType.I32) {
                UpdateSequenceNum = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 13:
              if (field.Type == TType.Struct) {
                AlternateData = new Data();
                AlternateData.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public void Write(TProtocol oprot) {
      oprot.IncrementRecursionDepth();
      try
      {
        TStruct struc = new TStruct("Resource");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (Guid != null && __isset.guid) {
          field.Name = "guid";
          field.Type = TType.String;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Guid);
          oprot.WriteFieldEnd();
        }
        if (NoteGuid != null && __isset.noteGuid) {
          field.Name = "noteGuid";
          field.Type = TType.String;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(NoteGuid);
          oprot.WriteFieldEnd();
        }
        if (Data != null && __isset.data) {
          field.Name = "data";
          field.Type = TType.Struct;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          Data.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (Mime != null && __isset.mime) {
          field.Name = "mime";
          field.Type = TType.String;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Mime);
          oprot.WriteFieldEnd();
        }
        if (__isset.width) {
          field.Name = "width";
          field.Type = TType.I16;
          field.ID = 5;
          oprot.WriteFieldBegin(field);
          oprot.WriteI16(Width);
          oprot.WriteFieldEnd();
        }
        if (__isset.height) {
          field.Name = "height";
          field.Type = TType.I16;
          field.ID = 6;
          oprot.WriteFieldBegin(field);
          oprot.WriteI16(Height);
          oprot.WriteFieldEnd();
        }
        if (__isset.duration) {
          field.Name = "duration";
          field.Type = TType.I16;
          field.ID = 7;
          oprot.WriteFieldBegin(field);
          oprot.WriteI16(Duration);
          oprot.WriteFieldEnd();
        }
        if (__isset.active) {
          field.Name = "active";
          field.Type = TType.Bool;
          field.ID = 8;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(Active);
          oprot.WriteFieldEnd();
        }
        if (Recognition != null && __isset.recognition) {
          field.Name = "recognition";
          field.Type = TType.Struct;
          field.ID = 9;
          oprot.WriteFieldBegin(field);
          Recognition.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (Attributes != null && __isset.attributes) {
          field.Name = "attributes";
          field.Type = TType.Struct;
          field.ID = 11;
          oprot.WriteFieldBegin(field);
          Attributes.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (__isset.updateSequenceNum) {
          field.Name = "updateSequenceNum";
          field.Type = TType.I32;
          field.ID = 12;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(UpdateSequenceNum);
          oprot.WriteFieldEnd();
        }
        if (AlternateData != null && __isset.alternateData) {
          field.Name = "alternateData";
          field.Type = TType.Struct;
          field.ID = 13;
          oprot.WriteFieldBegin(field);
          AlternateData.Write(oprot);
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("Resource(");
      bool __first = true;
      if (Guid != null && __isset.guid) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Guid: ");
        __sb.Append(Guid);
      }
      if (NoteGuid != null && __isset.noteGuid) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("NoteGuid: ");
        __sb.Append(NoteGuid);
      }
      if (Data != null && __isset.data) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Data: ");
        __sb.Append(Data== null ? "<null>" : Data.ToString());
      }
      if (Mime != null && __isset.mime) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Mime: ");
        __sb.Append(Mime);
      }
      if (__isset.width) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Width: ");
        __sb.Append(Width);
      }
      if (__isset.height) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Height: ");
        __sb.Append(Height);
      }
      if (__isset.duration) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Duration: ");
        __sb.Append(Duration);
      }
      if (__isset.active) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Active: ");
        __sb.Append(Active);
      }
      if (Recognition != null && __isset.recognition) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Recognition: ");
        __sb.Append(Recognition== null ? "<null>" : Recognition.ToString());
      }
      if (Attributes != null && __isset.attributes) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Attributes: ");
        __sb.Append(Attributes== null ? "<null>" : Attributes.ToString());
      }
      if (__isset.updateSequenceNum) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("UpdateSequenceNum: ");
        __sb.Append(UpdateSequenceNum);
      }
      if (AlternateData != null && __isset.alternateData) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("AlternateData: ");
        __sb.Append(AlternateData== null ? "<null>" : AlternateData.ToString());
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
