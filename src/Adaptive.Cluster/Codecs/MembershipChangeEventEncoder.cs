/* Generated SBE (Simple Binary Encoding) message codec */
using System;
using System.Text;
using System.Collections.Generic;
using Adaptive.Agrona;


namespace Adaptive.Cluster.Codecs {

public class MembershipChangeEventEncoder
{
    public const ushort BLOCK_LENGTH = 40;
    public const ushort TEMPLATE_ID = 25;
    public const ushort SCHEMA_ID = 111;
    public const ushort SCHEMA_VERSION = 8;

    private MembershipChangeEventEncoder _parentMessage;
    private IMutableDirectBuffer _buffer;
    protected int _offset;
    protected int _limit;

    public MembershipChangeEventEncoder()
    {
        _parentMessage = this;
    }

    public ushort SbeBlockLength()
    {
        return BLOCK_LENGTH;
    }

    public ushort SbeTemplateId()
    {
        return TEMPLATE_ID;
    }

    public ushort SbeSchemaId()
    {
        return SCHEMA_ID;
    }

    public ushort SbeSchemaVersion()
    {
        return SCHEMA_VERSION;
    }

    public string SbeSemanticType()
    {
        return "";
    }

    public IMutableDirectBuffer Buffer()
    {
        return _buffer;
    }

    public int Offset()
    {
        return _offset;
    }

    public MembershipChangeEventEncoder Wrap(IMutableDirectBuffer buffer, int offset)
    {
        this._buffer = buffer;
        this._offset = offset;
        Limit(offset + BLOCK_LENGTH);

        return this;
    }

    public MembershipChangeEventEncoder WrapAndApplyHeader(
        IMutableDirectBuffer buffer, int offset, MessageHeaderEncoder headerEncoder)
    {
        headerEncoder
            .Wrap(buffer, offset)
            .BlockLength(BLOCK_LENGTH)
            .TemplateId(TEMPLATE_ID)
            .SchemaId(SCHEMA_ID)
            .Version(SCHEMA_VERSION);

        return Wrap(buffer, offset + MessageHeaderEncoder.ENCODED_LENGTH);
    }

    public int EncodedLength()
    {
        return _limit - _offset;
    }

    public int Limit()
    {
        return _limit;
    }

    public void Limit(int limit)
    {
        this._limit = limit;
    }

    public static int LeadershipTermIdEncodingOffset()
    {
        return 0;
    }

    public static int LeadershipTermIdEncodingLength()
    {
        return 8;
    }

    public static long LeadershipTermIdNullValue()
    {
        return -9223372036854775808L;
    }

    public static long LeadershipTermIdMinValue()
    {
        return -9223372036854775807L;
    }

    public static long LeadershipTermIdMaxValue()
    {
        return 9223372036854775807L;
    }

    public MembershipChangeEventEncoder LeadershipTermId(long value)
    {
        _buffer.PutLong(_offset + 0, value, ByteOrder.LittleEndian);
        return this;
    }


    public static int LogPositionEncodingOffset()
    {
        return 8;
    }

    public static int LogPositionEncodingLength()
    {
        return 8;
    }

    public static long LogPositionNullValue()
    {
        return -9223372036854775808L;
    }

    public static long LogPositionMinValue()
    {
        return -9223372036854775807L;
    }

    public static long LogPositionMaxValue()
    {
        return 9223372036854775807L;
    }

    public MembershipChangeEventEncoder LogPosition(long value)
    {
        _buffer.PutLong(_offset + 8, value, ByteOrder.LittleEndian);
        return this;
    }


    public static int TimestampEncodingOffset()
    {
        return 16;
    }

    public static int TimestampEncodingLength()
    {
        return 8;
    }

    public static long TimestampNullValue()
    {
        return -9223372036854775808L;
    }

    public static long TimestampMinValue()
    {
        return -9223372036854775807L;
    }

    public static long TimestampMaxValue()
    {
        return 9223372036854775807L;
    }

    public MembershipChangeEventEncoder Timestamp(long value)
    {
        _buffer.PutLong(_offset + 16, value, ByteOrder.LittleEndian);
        return this;
    }


    public static int LeaderMemberIdEncodingOffset()
    {
        return 24;
    }

    public static int LeaderMemberIdEncodingLength()
    {
        return 4;
    }

    public static int LeaderMemberIdNullValue()
    {
        return -2147483648;
    }

    public static int LeaderMemberIdMinValue()
    {
        return -2147483647;
    }

    public static int LeaderMemberIdMaxValue()
    {
        return 2147483647;
    }

    public MembershipChangeEventEncoder LeaderMemberId(int value)
    {
        _buffer.PutInt(_offset + 24, value, ByteOrder.LittleEndian);
        return this;
    }


    public static int ClusterSizeEncodingOffset()
    {
        return 28;
    }

    public static int ClusterSizeEncodingLength()
    {
        return 4;
    }

    public static int ClusterSizeNullValue()
    {
        return -2147483648;
    }

    public static int ClusterSizeMinValue()
    {
        return -2147483647;
    }

    public static int ClusterSizeMaxValue()
    {
        return 2147483647;
    }

    public MembershipChangeEventEncoder ClusterSize(int value)
    {
        _buffer.PutInt(_offset + 28, value, ByteOrder.LittleEndian);
        return this;
    }


    public static int ChangeTypeEncodingOffset()
    {
        return 32;
    }

    public static int ChangeTypeEncodingLength()
    {
        return 4;
    }

    public MembershipChangeEventEncoder ChangeType(ChangeType value)
    {
        _buffer.PutInt(_offset + 32, (int)value, ByteOrder.LittleEndian);
        return this;
    }

    public static int MemberIdEncodingOffset()
    {
        return 36;
    }

    public static int MemberIdEncodingLength()
    {
        return 4;
    }

    public static int MemberIdNullValue()
    {
        return -2147483648;
    }

    public static int MemberIdMinValue()
    {
        return -2147483647;
    }

    public static int MemberIdMaxValue()
    {
        return 2147483647;
    }

    public MembershipChangeEventEncoder MemberId(int value)
    {
        _buffer.PutInt(_offset + 36, value, ByteOrder.LittleEndian);
        return this;
    }


    public static int ClusterMembersId()
    {
        return 8;
    }

    public static string ClusterMembersCharacterEncoding()
    {
        return "US-ASCII";
    }

    public static string ClusterMembersMetaAttribute(MetaAttribute metaAttribute)
    {
        switch (metaAttribute)
        {
            case MetaAttribute.EPOCH: return "unix";
            case MetaAttribute.TIME_UNIT: return "nanosecond";
            case MetaAttribute.SEMANTIC_TYPE: return "";
            case MetaAttribute.PRESENCE: return "required";
        }

        return "";
    }

    public static int ClusterMembersHeaderLength()
    {
        return 4;
    }

    public MembershipChangeEventEncoder PutClusterMembers(IDirectBuffer src, int srcOffset, int length)
    {
        if (length > 1073741824)
        {
            throw new InvalidOperationException("length > maxValue for type: " + length);
        }

        int headerLength = 4;
        int limit = _parentMessage.Limit();
        _parentMessage.Limit(limit + headerLength + length);
        _buffer.PutInt(limit, unchecked((int)length), ByteOrder.LittleEndian);
        _buffer.PutBytes(limit + headerLength, src, srcOffset, length);

        return this;
    }

    public MembershipChangeEventEncoder PutClusterMembers(byte[] src, int srcOffset, int length)
    {
        if (length > 1073741824)
        {
            throw new InvalidOperationException("length > maxValue for type: " + length);
        }

        int headerLength = 4;
        int limit = _parentMessage.Limit();
        _parentMessage.Limit(limit + headerLength + length);
        _buffer.PutInt(limit, unchecked((int)length), ByteOrder.LittleEndian);
        _buffer.PutBytes(limit + headerLength, src, srcOffset, length);

        return this;
    }

    public MembershipChangeEventEncoder ClusterMembers(string value)
    {
        int length = value.Length;
        if (length > 1073741824)
        {
            throw new InvalidOperationException("length > maxValue for type: " + length);
        }

        int headerLength = 4;
        int limit = _parentMessage.Limit();
        _parentMessage.Limit(limit + headerLength + length);
        _buffer.PutInt(limit, unchecked((int)length), ByteOrder.LittleEndian);
        _buffer.PutStringWithoutLengthAscii(limit + headerLength, value);

        return this;
    }


    public override string ToString()
    {
        return AppendTo(new StringBuilder(100)).ToString();
    }

    public StringBuilder AppendTo(StringBuilder builder)
    {
        MembershipChangeEventDecoder writer = new MembershipChangeEventDecoder();
        writer.Wrap(_buffer, _offset, BLOCK_LENGTH, SCHEMA_VERSION);

        return writer.AppendTo(builder);
    }
}
}
