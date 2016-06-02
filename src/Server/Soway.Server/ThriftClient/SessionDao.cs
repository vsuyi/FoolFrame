/**
 * Autogenerated by Thrift Compiler (0.9.1)
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

public partial class SessionDao {
  public interface Iface {
    byte[] getSession(org.soldier.platform.svr_platform.comm.PlatformArgs platformArgs, string sessionKey);
    #if SILVERLIGHT
    IAsyncResult Begin_getSession(AsyncCallback callback, object state, org.soldier.platform.svr_platform.comm.PlatformArgs platformArgs, string sessionKey);
    byte[] End_getSession(IAsyncResult asyncResult);
    #endif
    void updateSession(org.soldier.platform.svr_platform.comm.PlatformArgs platformArgs, string sessionKey, byte[] sessionValue, int expireSeconds);
    #if SILVERLIGHT
    IAsyncResult Begin_updateSession(AsyncCallback callback, object state, org.soldier.platform.svr_platform.comm.PlatformArgs platformArgs, string sessionKey, byte[] sessionValue, int expireSeconds);
    void End_updateSession(IAsyncResult asyncResult);
    #endif
    void deleteSession(org.soldier.platform.svr_platform.comm.PlatformArgs platformArgs, string sessionKey);
    #if SILVERLIGHT
    IAsyncResult Begin_deleteSession(AsyncCallback callback, object state, org.soldier.platform.svr_platform.comm.PlatformArgs platformArgs, string sessionKey);
    void End_deleteSession(IAsyncResult asyncResult);
    #endif
  }

  public class Client : IDisposable, Iface {
    public Client(TProtocol prot) : this(prot, prot)
    {
    }

    public Client(TProtocol iprot, TProtocol oprot)
    {
      iprot_ = iprot;
      oprot_ = oprot;
    }

    protected TProtocol iprot_;
    protected TProtocol oprot_;
    protected int seqid_;

    public TProtocol InputProtocol
    {
      get { return iprot_; }
    }
    public TProtocol OutputProtocol
    {
      get { return oprot_; }
    }


    #region " IDisposable Support "
    private bool _IsDisposed;

    // IDisposable
    public void Dispose()
    {
      Dispose(true);
    }
    

    protected virtual void Dispose(bool disposing)
    {
      if (!_IsDisposed)
      {
        if (disposing)
        {
          if (iprot_ != null)
          {
            ((IDisposable)iprot_).Dispose();
          }
          if (oprot_ != null)
          {
            ((IDisposable)oprot_).Dispose();
          }
        }
      }
      _IsDisposed = true;
    }
    #endregion


    
    #if SILVERLIGHT
    public IAsyncResult Begin_getSession(AsyncCallback callback, object state, org.soldier.platform.svr_platform.comm.PlatformArgs platformArgs, string sessionKey)
    {
      return send_getSession(callback, state, platformArgs, sessionKey);
    }

    public byte[] End_getSession(IAsyncResult asyncResult)
    {
      oprot_.Transport.EndFlush(asyncResult);
      return recv_getSession();
    }

    #endif

    public byte[] getSession(org.soldier.platform.svr_platform.comm.PlatformArgs platformArgs, string sessionKey)
    {
      #if !SILVERLIGHT
      send_getSession(platformArgs, sessionKey);
      return recv_getSession();

      #else
      var asyncResult = Begin_getSession(null, null, platformArgs, sessionKey);
      return End_getSession(asyncResult);

      #endif
    }
    #if SILVERLIGHT
    public IAsyncResult send_getSession(AsyncCallback callback, object state, org.soldier.platform.svr_platform.comm.PlatformArgs platformArgs, string sessionKey)
    #else
    public void send_getSession(org.soldier.platform.svr_platform.comm.PlatformArgs platformArgs, string sessionKey)
    #endif
    {
      oprot_.WriteMessageBegin(new TMessage("getSession", TMessageType.Call, seqid_));
      getSession_args args = new getSession_args();
      args.PlatformArgs = platformArgs;
      args.SessionKey = sessionKey;
      args.Write(oprot_);
      oprot_.WriteMessageEnd();
      #if SILVERLIGHT
      return oprot_.Transport.BeginFlush(callback, state);
      #else
      oprot_.Transport.Flush();
      #endif
    }

    public byte[] recv_getSession()
    {
      TMessage msg = iprot_.ReadMessageBegin();
      if (msg.Type == TMessageType.Exception) {
        TApplicationException x = TApplicationException.Read(iprot_);
        iprot_.ReadMessageEnd();
        throw x;
      }
      getSession_result result = new getSession_result();
      result.Read(iprot_);
      iprot_.ReadMessageEnd();
      if (result.__isset.success) {
        return result.Success;
      }
      if (result.__isset.err) {
        throw result.Err;
      }
      throw new TApplicationException(TApplicationException.ExceptionType.MissingResult, "getSession failed: unknown result");
    }

    
    #if SILVERLIGHT
    public IAsyncResult Begin_updateSession(AsyncCallback callback, object state, org.soldier.platform.svr_platform.comm.PlatformArgs platformArgs, string sessionKey, byte[] sessionValue, int expireSeconds)
    {
      return send_updateSession(callback, state, platformArgs, sessionKey, sessionValue, expireSeconds);
    }

    public void End_updateSession(IAsyncResult asyncResult)
    {
      oprot_.Transport.EndFlush(asyncResult);
      recv_updateSession();
    }

    #endif

    public void updateSession(org.soldier.platform.svr_platform.comm.PlatformArgs platformArgs, string sessionKey, byte[] sessionValue, int expireSeconds)
    {
      #if !SILVERLIGHT
      send_updateSession(platformArgs, sessionKey, sessionValue, expireSeconds);
      recv_updateSession();

      #else
      var asyncResult = Begin_updateSession(null, null, platformArgs, sessionKey, sessionValue, expireSeconds);
      End_updateSession(asyncResult);

      #endif
    }
    #if SILVERLIGHT
    public IAsyncResult send_updateSession(AsyncCallback callback, object state, org.soldier.platform.svr_platform.comm.PlatformArgs platformArgs, string sessionKey, byte[] sessionValue, int expireSeconds)
    #else
    public void send_updateSession(org.soldier.platform.svr_platform.comm.PlatformArgs platformArgs, string sessionKey, byte[] sessionValue, int expireSeconds)
    #endif
    {
      oprot_.WriteMessageBegin(new TMessage("updateSession", TMessageType.Call, seqid_));
      updateSession_args args = new updateSession_args();
      args.PlatformArgs = platformArgs;
      args.SessionKey = sessionKey;
      args.SessionValue = sessionValue;
      args.ExpireSeconds = expireSeconds;
      args.Write(oprot_);
      oprot_.WriteMessageEnd();
      #if SILVERLIGHT
      return oprot_.Transport.BeginFlush(callback, state);
      #else
      oprot_.Transport.Flush();
      #endif
    }

    public void recv_updateSession()
    {
      TMessage msg = iprot_.ReadMessageBegin();
      if (msg.Type == TMessageType.Exception) {
        TApplicationException x = TApplicationException.Read(iprot_);
        iprot_.ReadMessageEnd();
        throw x;
      }
      updateSession_result result = new updateSession_result();
      result.Read(iprot_);
      iprot_.ReadMessageEnd();
      if (result.__isset.err) {
        throw result.Err;
      }
      return;
    }

    
    #if SILVERLIGHT
    public IAsyncResult Begin_deleteSession(AsyncCallback callback, object state, org.soldier.platform.svr_platform.comm.PlatformArgs platformArgs, string sessionKey)
    {
      return send_deleteSession(callback, state, platformArgs, sessionKey);
    }

    public void End_deleteSession(IAsyncResult asyncResult)
    {
      oprot_.Transport.EndFlush(asyncResult);
      recv_deleteSession();
    }

    #endif

    public void deleteSession(org.soldier.platform.svr_platform.comm.PlatformArgs platformArgs, string sessionKey)
    {
      #if !SILVERLIGHT
      send_deleteSession(platformArgs, sessionKey);
      recv_deleteSession();

      #else
      var asyncResult = Begin_deleteSession(null, null, platformArgs, sessionKey);
      End_deleteSession(asyncResult);

      #endif
    }
    #if SILVERLIGHT
    public IAsyncResult send_deleteSession(AsyncCallback callback, object state, org.soldier.platform.svr_platform.comm.PlatformArgs platformArgs, string sessionKey)
    #else
    public void send_deleteSession(org.soldier.platform.svr_platform.comm.PlatformArgs platformArgs, string sessionKey)
    #endif
    {
      oprot_.WriteMessageBegin(new TMessage("deleteSession", TMessageType.Call, seqid_));
      deleteSession_args args = new deleteSession_args();
      args.PlatformArgs = platformArgs;
      args.SessionKey = sessionKey;
      args.Write(oprot_);
      oprot_.WriteMessageEnd();
      #if SILVERLIGHT
      return oprot_.Transport.BeginFlush(callback, state);
      #else
      oprot_.Transport.Flush();
      #endif
    }

    public void recv_deleteSession()
    {
      TMessage msg = iprot_.ReadMessageBegin();
      if (msg.Type == TMessageType.Exception) {
        TApplicationException x = TApplicationException.Read(iprot_);
        iprot_.ReadMessageEnd();
        throw x;
      }
      deleteSession_result result = new deleteSession_result();
      result.Read(iprot_);
      iprot_.ReadMessageEnd();
      if (result.__isset.err) {
        throw result.Err;
      }
      return;
    }

  }
  public class Processor : TProcessor {
    public Processor(Iface iface)
    {
      iface_ = iface;
      processMap_["getSession"] = getSession_Process;
      processMap_["updateSession"] = updateSession_Process;
      processMap_["deleteSession"] = deleteSession_Process;
    }

    protected delegate void ProcessFunction(int seqid, TProtocol iprot, TProtocol oprot);
    private Iface iface_;
    protected Dictionary<string, ProcessFunction> processMap_ = new Dictionary<string, ProcessFunction>();

    public bool Process(TProtocol iprot, TProtocol oprot)
    {
      try
      {
        TMessage msg = iprot.ReadMessageBegin();
        ProcessFunction fn;
        processMap_.TryGetValue(msg.Name, out fn);
        if (fn == null) {
          TProtocolUtil.Skip(iprot, TType.Struct);
          iprot.ReadMessageEnd();
          TApplicationException x = new TApplicationException (TApplicationException.ExceptionType.UnknownMethod, "Invalid method name: '" + msg.Name + "'");
          oprot.WriteMessageBegin(new TMessage(msg.Name, TMessageType.Exception, msg.SeqID));
          x.Write(oprot);
          oprot.WriteMessageEnd();
          oprot.Transport.Flush();
          return true;
        }
        fn(msg.SeqID, iprot, oprot);
      }
      catch (IOException)
      {
        return false;
      }
      return true;
    }

    public void getSession_Process(int seqid, TProtocol iprot, TProtocol oprot)
    {
      getSession_args args = new getSession_args();
      args.Read(iprot);
      iprot.ReadMessageEnd();
      getSession_result result = new getSession_result();
      try {
        result.Success = iface_.getSession(args.PlatformArgs, args.SessionKey);
      } catch (org.soldier.platform.svr_platform.comm.ErrorInfo err) {
        result.Err = err;
      }
      oprot.WriteMessageBegin(new TMessage("getSession", TMessageType.Reply, seqid)); 
      result.Write(oprot);
      oprot.WriteMessageEnd();
      oprot.Transport.Flush();
    }

    public void updateSession_Process(int seqid, TProtocol iprot, TProtocol oprot)
    {
      updateSession_args args = new updateSession_args();
      args.Read(iprot);
      iprot.ReadMessageEnd();
      updateSession_result result = new updateSession_result();
      try {
        iface_.updateSession(args.PlatformArgs, args.SessionKey, args.SessionValue, args.ExpireSeconds);
      } catch (org.soldier.platform.svr_platform.comm.ErrorInfo err) {
        result.Err = err;
      }
      oprot.WriteMessageBegin(new TMessage("updateSession", TMessageType.Reply, seqid)); 
      result.Write(oprot);
      oprot.WriteMessageEnd();
      oprot.Transport.Flush();
    }

    public void deleteSession_Process(int seqid, TProtocol iprot, TProtocol oprot)
    {
      deleteSession_args args = new deleteSession_args();
      args.Read(iprot);
      iprot.ReadMessageEnd();
      deleteSession_result result = new deleteSession_result();
      try {
        iface_.deleteSession(args.PlatformArgs, args.SessionKey);
      } catch (org.soldier.platform.svr_platform.comm.ErrorInfo err) {
        result.Err = err;
      }
      oprot.WriteMessageBegin(new TMessage("deleteSession", TMessageType.Reply, seqid)); 
      result.Write(oprot);
      oprot.WriteMessageEnd();
      oprot.Transport.Flush();
    }

  }


  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class getSession_args : TBase
  {
    private org.soldier.platform.svr_platform.comm.PlatformArgs _platformArgs;
    private string _sessionKey;

    public org.soldier.platform.svr_platform.comm.PlatformArgs PlatformArgs
    {
      get
      {
        return _platformArgs;
      }
      set
      {
        __isset.platformArgs = true;
        this._platformArgs = value;
      }
    }

    public string SessionKey
    {
      get
      {
        return _sessionKey;
      }
      set
      {
        __isset.sessionKey = true;
        this._sessionKey = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool platformArgs;
      public bool sessionKey;
    }

    public getSession_args() {
    }

    public void Read (TProtocol iprot)
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
            if (field.Type == TType.Struct) {
              PlatformArgs = new org.soldier.platform.svr_platform.comm.PlatformArgs();
              PlatformArgs.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              SessionKey = iprot.ReadString();
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

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("getSession_args");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (PlatformArgs != null && __isset.platformArgs) {
        field.Name = "platformArgs";
        field.Type = TType.Struct;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        PlatformArgs.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (SessionKey != null && __isset.sessionKey) {
        field.Name = "sessionKey";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(SessionKey);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("getSession_args(");
      sb.Append("PlatformArgs: ");
      sb.Append(PlatformArgs== null ? "<null>" : PlatformArgs.ToString());
      sb.Append(",SessionKey: ");
      sb.Append(SessionKey);
      sb.Append(")");
      return sb.ToString();
    }

  }


  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class getSession_result : TBase
  {
    private byte[] _success;
    private org.soldier.platform.svr_platform.comm.ErrorInfo _err;

    public byte[] Success
    {
      get
      {
        return _success;
      }
      set
      {
        __isset.success = true;
        this._success = value;
      }
    }

    public org.soldier.platform.svr_platform.comm.ErrorInfo Err
    {
      get
      {
        return _err;
      }
      set
      {
        __isset.err = true;
        this._err = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool success;
      public bool err;
    }

    public getSession_result() {
    }

    public void Read (TProtocol iprot)
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
          case 0:
            if (field.Type == TType.String) {
              Success = iprot.ReadBinary();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 1:
            if (field.Type == TType.Struct) {
              Err = new org.soldier.platform.svr_platform.comm.ErrorInfo();
              Err.Read(iprot);
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

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("getSession_result");
      oprot.WriteStructBegin(struc);
      TField field = new TField();

      if (this.__isset.success) {
        if (Success != null) {
          field.Name = "Success";
          field.Type = TType.String;
          field.ID = 0;
          oprot.WriteFieldBegin(field);
          oprot.WriteBinary(Success);
          oprot.WriteFieldEnd();
        }
      } else if (this.__isset.err) {
        if (Err != null) {
          field.Name = "Err";
          field.Type = TType.Struct;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          Err.Write(oprot);
          oprot.WriteFieldEnd();
        }
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("getSession_result(");
      sb.Append("Success: ");
      sb.Append(Success);
      sb.Append(",Err: ");
      sb.Append(Err== null ? "<null>" : Err.ToString());
      sb.Append(")");
      return sb.ToString();
    }

  }


  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class updateSession_args : TBase
  {
    private org.soldier.platform.svr_platform.comm.PlatformArgs _platformArgs;
    private string _sessionKey;
    private byte[] _sessionValue;
    private int _expireSeconds;

    public org.soldier.platform.svr_platform.comm.PlatformArgs PlatformArgs
    {
      get
      {
        return _platformArgs;
      }
      set
      {
        __isset.platformArgs = true;
        this._platformArgs = value;
      }
    }

    public string SessionKey
    {
      get
      {
        return _sessionKey;
      }
      set
      {
        __isset.sessionKey = true;
        this._sessionKey = value;
      }
    }

    public byte[] SessionValue
    {
      get
      {
        return _sessionValue;
      }
      set
      {
        __isset.sessionValue = true;
        this._sessionValue = value;
      }
    }

    public int ExpireSeconds
    {
      get
      {
        return _expireSeconds;
      }
      set
      {
        __isset.expireSeconds = true;
        this._expireSeconds = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool platformArgs;
      public bool sessionKey;
      public bool sessionValue;
      public bool expireSeconds;
    }

    public updateSession_args() {
    }

    public void Read (TProtocol iprot)
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
            if (field.Type == TType.Struct) {
              PlatformArgs = new org.soldier.platform.svr_platform.comm.PlatformArgs();
              PlatformArgs.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              SessionKey = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.String) {
              SessionValue = iprot.ReadBinary();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I32) {
              ExpireSeconds = iprot.ReadI32();
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

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("updateSession_args");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (PlatformArgs != null && __isset.platformArgs) {
        field.Name = "platformArgs";
        field.Type = TType.Struct;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        PlatformArgs.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (SessionKey != null && __isset.sessionKey) {
        field.Name = "sessionKey";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(SessionKey);
        oprot.WriteFieldEnd();
      }
      if (SessionValue != null && __isset.sessionValue) {
        field.Name = "sessionValue";
        field.Type = TType.String;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteBinary(SessionValue);
        oprot.WriteFieldEnd();
      }
      if (__isset.expireSeconds) {
        field.Name = "expireSeconds";
        field.Type = TType.I32;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(ExpireSeconds);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("updateSession_args(");
      sb.Append("PlatformArgs: ");
      sb.Append(PlatformArgs== null ? "<null>" : PlatformArgs.ToString());
      sb.Append(",SessionKey: ");
      sb.Append(SessionKey);
      sb.Append(",SessionValue: ");
      sb.Append(SessionValue);
      sb.Append(",ExpireSeconds: ");
      sb.Append(ExpireSeconds);
      sb.Append(")");
      return sb.ToString();
    }

  }


  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class updateSession_result : TBase
  {
    private org.soldier.platform.svr_platform.comm.ErrorInfo _err;

    public org.soldier.platform.svr_platform.comm.ErrorInfo Err
    {
      get
      {
        return _err;
      }
      set
      {
        __isset.err = true;
        this._err = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool err;
    }

    public updateSession_result() {
    }

    public void Read (TProtocol iprot)
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
            if (field.Type == TType.Struct) {
              Err = new org.soldier.platform.svr_platform.comm.ErrorInfo();
              Err.Read(iprot);
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

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("updateSession_result");
      oprot.WriteStructBegin(struc);
      TField field = new TField();

      if (this.__isset.err) {
        if (Err != null) {
          field.Name = "Err";
          field.Type = TType.Struct;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          Err.Write(oprot);
          oprot.WriteFieldEnd();
        }
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("updateSession_result(");
      sb.Append("Err: ");
      sb.Append(Err== null ? "<null>" : Err.ToString());
      sb.Append(")");
      return sb.ToString();
    }

  }


  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class deleteSession_args : TBase
  {
    private org.soldier.platform.svr_platform.comm.PlatformArgs _platformArgs;
    private string _sessionKey;

    public org.soldier.platform.svr_platform.comm.PlatformArgs PlatformArgs
    {
      get
      {
        return _platformArgs;
      }
      set
      {
        __isset.platformArgs = true;
        this._platformArgs = value;
      }
    }

    public string SessionKey
    {
      get
      {
        return _sessionKey;
      }
      set
      {
        __isset.sessionKey = true;
        this._sessionKey = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool platformArgs;
      public bool sessionKey;
    }

    public deleteSession_args() {
    }

    public void Read (TProtocol iprot)
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
            if (field.Type == TType.Struct) {
              PlatformArgs = new org.soldier.platform.svr_platform.comm.PlatformArgs();
              PlatformArgs.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              SessionKey = iprot.ReadString();
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

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("deleteSession_args");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (PlatformArgs != null && __isset.platformArgs) {
        field.Name = "platformArgs";
        field.Type = TType.Struct;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        PlatformArgs.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (SessionKey != null && __isset.sessionKey) {
        field.Name = "sessionKey";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(SessionKey);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("deleteSession_args(");
      sb.Append("PlatformArgs: ");
      sb.Append(PlatformArgs== null ? "<null>" : PlatformArgs.ToString());
      sb.Append(",SessionKey: ");
      sb.Append(SessionKey);
      sb.Append(")");
      return sb.ToString();
    }

  }


  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class deleteSession_result : TBase
  {
    private org.soldier.platform.svr_platform.comm.ErrorInfo _err;

    public org.soldier.platform.svr_platform.comm.ErrorInfo Err
    {
      get
      {
        return _err;
      }
      set
      {
        __isset.err = true;
        this._err = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool err;
    }

    public deleteSession_result() {
    }

    public void Read (TProtocol iprot)
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
            if (field.Type == TType.Struct) {
              Err = new org.soldier.platform.svr_platform.comm.ErrorInfo();
              Err.Read(iprot);
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

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("deleteSession_result");
      oprot.WriteStructBegin(struc);
      TField field = new TField();

      if (this.__isset.err) {
        if (Err != null) {
          field.Name = "Err";
          field.Type = TType.Struct;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          Err.Write(oprot);
          oprot.WriteFieldEnd();
        }
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("deleteSession_result(");
      sb.Append("Err: ");
      sb.Append(Err== null ? "<null>" : Err.ToString());
      sb.Append(")");
      return sb.ToString();
    }

  }

}