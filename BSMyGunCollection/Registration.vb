Imports Microsoft.Win32
Imports System
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Namespace Cyhper
    Friend Class CMD5


        Private Const BITS_TO_A_BYTE As Integer = 8
        Private Const BYTES_TO_A_WORD As Integer = 4
        Private Const BITS_TO_A_WORD As Integer = BYTES_TO_A_WORD * BITS_TO_A_BYTE

        Private m_lOnBits(30) As Integer
        Private m_l2Power(30) As Integer

        '*******************************************************************************
        ' Class_Initialize (SUB)
        '
        ' DESCRIPTION:
        ' We will usually get quicker results by preparing arrays of bit patterns and
        ' powers of 2 ahead of time instead of calculating them every time, unless of
        ' course the methods are only ever getting called once per instantiation of the
        ' class.
        '*******************************************************************************
        Private Sub Class_Initialize_Renamed()
            ' Could have done this with a loop calculating each value, but simply
            ' assigning the values is quicker - BITS SET FROM RIGHT
            m_lOnBits(0) = 1 ' 00000000000000000000000000000001
            m_lOnBits(1) = 3 ' 00000000000000000000000000000011
            m_lOnBits(2) = 7 ' 00000000000000000000000000000111
            m_lOnBits(3) = 15 ' 00000000000000000000000000001111
            m_lOnBits(4) = 31 ' 00000000000000000000000000011111
            m_lOnBits(5) = 63 ' 00000000000000000000000000111111
            m_lOnBits(6) = 127 ' 00000000000000000000000001111111
            m_lOnBits(7) = 255 ' 00000000000000000000000011111111
            m_lOnBits(8) = 511 ' 00000000000000000000000111111111
            m_lOnBits(9) = 1023 ' 00000000000000000000001111111111
            m_lOnBits(10) = 2047 ' 00000000000000000000011111111111
            m_lOnBits(11) = 4095 ' 00000000000000000000111111111111
            m_lOnBits(12) = 8191 ' 00000000000000000001111111111111
            m_lOnBits(13) = 16383 ' 00000000000000000011111111111111
            m_lOnBits(14) = 32767 ' 00000000000000000111111111111111
            m_lOnBits(15) = 65535 ' 00000000000000001111111111111111
            m_lOnBits(16) = 131071 ' 00000000000000011111111111111111
            m_lOnBits(17) = 262143 ' 00000000000000111111111111111111
            m_lOnBits(18) = 524287 ' 00000000000001111111111111111111
            m_lOnBits(19) = 1048575 ' 00000000000011111111111111111111
            m_lOnBits(20) = 2097151 ' 00000000000111111111111111111111
            m_lOnBits(21) = 4194303 ' 00000000001111111111111111111111
            m_lOnBits(22) = 8388607 ' 00000000011111111111111111111111
            m_lOnBits(23) = 16777215 ' 00000000111111111111111111111111
            m_lOnBits(24) = 33554431 ' 00000001111111111111111111111111
            m_lOnBits(25) = 67108863 ' 00000011111111111111111111111111
            m_lOnBits(26) = 134217727 ' 00000111111111111111111111111111
            m_lOnBits(27) = 268435455 ' 00001111111111111111111111111111
            m_lOnBits(28) = 536870911 ' 00011111111111111111111111111111
            m_lOnBits(29) = 1073741823 ' 00111111111111111111111111111111
            m_lOnBits(30) = 2147483647 ' 01111111111111111111111111111111

            ' Could have done this with a loop calculating each value, but simply
            ' assigning the values is quicker - POWERS OF 2
            m_l2Power(0) = 1 ' 00000000000000000000000000000001
            m_l2Power(1) = 2 ' 00000000000000000000000000000010
            m_l2Power(2) = 4 ' 00000000000000000000000000000100
            m_l2Power(3) = 8 ' 00000000000000000000000000001000
            m_l2Power(4) = 16 ' 00000000000000000000000000010000
            m_l2Power(5) = 32 ' 00000000000000000000000000100000
            m_l2Power(6) = 64 ' 00000000000000000000000001000000
            m_l2Power(7) = 128 ' 00000000000000000000000010000000
            m_l2Power(8) = 256 ' 00000000000000000000000100000000
            m_l2Power(9) = 512 ' 00000000000000000000001000000000
            m_l2Power(10) = 1024 ' 00000000000000000000010000000000
            m_l2Power(11) = 2048 ' 00000000000000000000100000000000
            m_l2Power(12) = 4096 ' 00000000000000000001000000000000
            m_l2Power(13) = 8192 ' 00000000000000000010000000000000
            m_l2Power(14) = 16384 ' 00000000000000000100000000000000
            m_l2Power(15) = 32768 ' 00000000000000001000000000000000
            m_l2Power(16) = 65536 ' 00000000000000010000000000000000
            m_l2Power(17) = 131072 ' 00000000000000100000000000000000
            m_l2Power(18) = 262144 ' 00000000000001000000000000000000
            m_l2Power(19) = 524288 ' 00000000000010000000000000000000
            m_l2Power(20) = 1048576 ' 00000000000100000000000000000000
            m_l2Power(21) = 2097152 ' 00000000001000000000000000000000
            m_l2Power(22) = 4194304 ' 00000000010000000000000000000000
            m_l2Power(23) = 8388608 ' 00000000100000000000000000000000
            m_l2Power(24) = 16777216 ' 00000001000000000000000000000000
            m_l2Power(25) = 33554432 ' 00000010000000000000000000000000
            m_l2Power(26) = 67108864 ' 00000100000000000000000000000000
            m_l2Power(27) = 134217728 ' 00001000000000000000000000000000
            m_l2Power(28) = 268435456 ' 00010000000000000000000000000000
            m_l2Power(29) = 536870912 ' 00100000000000000000000000000000
            m_l2Power(30) = 1073741824 ' 01000000000000000000000000000000
        End Sub
        Public Sub New()
            MyBase.New()
            Class_Initialize_Renamed()
        End Sub

        '*******************************************************************************
        ' LShift (FUNCTION)
        '
        ' PARAMETERS:
        ' (In) - lValue     - Long    - The value to be shifted
        ' (In) - iShiftBits - Integer - The number of bits to shift the value by
        '
        ' RETURN VALUE:
        ' Long - The shifted long integer
        '
        ' DESCRIPTION:
        ' A left shift takes all the set binary bits and moves them left, in-filling
        ' with zeros in the vacated bits on the right. This function is equivalent to
        ' the << operator in Java and C++
        '*******************************************************************************
        Private Function LShift(ByVal lValue As Integer, ByVal iShiftBits As Short) As Integer
            ' NOTE: If you can guarantee that the Shift parameter will be in the
            ' range 1 to 30 you can safely strip of this first nested if structure for
            ' speed.
            '
            ' A shift of zero is no shift at all.
            If iShiftBits = 0 Then
                LShift = lValue
                Exit Function

                ' A shift of 31 will result in the right most bit becoming the left most
                ' bit and all other bits being cleared
            ElseIf iShiftBits = 31 Then
                If lValue And 1 Then
                    LShift = &H80000000
                Else
                    LShift = 0
                End If
                Exit Function

                ' A shift of less than zero or more than 31 is undefined
            ElseIf iShiftBits < 0 Or iShiftBits > 31 Then
                Err.Raise(6)
            End If

            ' If the left most bit that remains will end up in the negative bit
            ' position (&H80000000) we would end up with an overflow if we took the
            ' standard route. We need to strip the left most bit and add it back
            ' afterwards.
            If (lValue And m_l2Power(31 - iShiftBits)) Then

                ' (Value And OnBits(31 - (Shift + 1))) chops off the left most bits that
                ' we are shifting into, but also the left most bit we still want as this
                ' is going to end up in the negative bit marker position (&H80000000).
                ' After the multiplication/shift we Or the result with &H80000000 to
                ' turn the negative bit on.
                'LShift = (CShort(lValue And m_lOnBits(31 - (iShiftBits + 1))) * m_l2Power(iShiftBits)) Or &H80000000
                LShift = ((lValue And m_lOnBits(31 - (iShiftBits + 1))) * m_l2Power(iShiftBits)) Or &H80000000
            Else

                ' (Value And OnBits(31-Shift)) chops off the left most bits that we are
                ' shifting into so we do not get an overflow error when we do the
                ' multiplication/shift
                'LShift = (CShort(lValue And m_lOnBits(31 - iShiftBits)) * m_l2Power(iShiftBits))
                LShift = ((lValue And m_lOnBits(31 - iShiftBits)) * m_l2Power(iShiftBits))

            End If
        End Function

        '*******************************************************************************
        ' RShift (FUNCTION)
        '
        ' PARAMETERS:
        ' (In) - lValue     - Long    - The value to be shifted
        ' (In) - iShiftBits - Integer - The number of bits to shift the value by
        '
        ' RETURN VALUE:
        ' Long - The shifted long integer
        '
        ' DESCRIPTION:
        ' The right shift of an unsigned long integer involves shifting all the set bits
        ' to the right and in-filling on the left with zeros. This function is
        ' equivalent to the >>> operator in Java or the >> operator in C++ when used on
        ' an unsigned long.
        '*******************************************************************************
        Private Function RShift(ByVal lValue As Integer, ByVal iShiftBits As Short) As Integer

            ' NOTE: If you can guarantee that the Shift parameter will be in the
            ' range 1 to 30 you can safely strip of this first nested if structure for
            ' speed.
            '
            ' A shift of zero is no shift at all
            If iShiftBits = 0 Then
                RShift = lValue
                Exit Function

                ' A shift of 31 will clear all bits and move the left most bit to the right
                ' most bit position
            ElseIf iShiftBits = 31 Then
                If lValue And &H80000000 Then
                    RShift = 1
                Else
                    RShift = 0
                End If
                Exit Function

                ' A shift of less than zero or more than 31 is undefined
            ElseIf iShiftBits < 0 Or iShiftBits > 31 Then
                Err.Raise(6)
            End If

            ' We do not care about the top most bit or the final bit, the top most bit
            ' will be taken into account in the next stage, the final bit (whether it
            ' is an odd number or not) is being shifted into, so we do not give a jot
            ' about it
            RShift = (lValue And &H7FFFFFFE) \ m_l2Power(iShiftBits)

            ' If the top most bit (&H80000000) was set we need to do things differently
            ' as in a normal VB signed long integer the top most bit is used to indicate
            ' the sign of the number, when it is set it is a negative number, so just
            ' dividing by a factor of 2 as above would not work.
            ' NOTE: (lValue And  &H80000000) is equivalent to (lValue < 0), you could
            ' get a very marginal speed improvement by changing the test to (lValue < 0)
            If (lValue And &H80000000) Then
                ' We take the value computed so far, and then add the left most negative
                ' bit after it has been shifted to the right the appropriate number of
                ' places
                RShift = (RShift Or (&H40000000 \ m_l2Power(iShiftBits - 1)))
            End If
        End Function

        '*******************************************************************************
        ' RShiftSigned (FUNCTION)
        '
        ' PARAMETERS:
        ' (In) - lValue     - Long    -
        ' (In) - iShiftBits - Integer -
        '
        ' RETURN VALUE:
        ' Long -
        '
        ' DESCRIPTION:
        ' The right shift of a signed long integer involves shifting all the set bits to
        ' the right and in-filling on the left with the sign bit (0 if positive, 1 if
        ' negative. This function is equivalent to the >> operator in Java or the >>
        ' operator in C++ when used on a signed long integer. Not used in this class,
        ' but included for completeness.
        '*******************************************************************************
        Private Function RShiftSigned(ByVal lValue As Integer, ByVal iShiftBits As Short) As Integer

            ' NOTE: If you can guarantee that the Shift parameter will be in the
            ' range 1 to 30 you can safely strip of this first nested if structure for
            ' speed.
            '
            ' A shift of zero is no shift at all
            If iShiftBits = 0 Then
                RShiftSigned = lValue
                Exit Function

                ' A shift of 31 will clear all bits if the left most bit was zero, and will
                ' set all bits if the left most bit was 1 (a negative indicator)
            ElseIf iShiftBits = 31 Then

                ' NOTE: (lValue And  &H80000000) is equivalent to (lValue < 0), you
                ' could get a very marginal speed improvement by changing the test to
                ' (lValue < 0)
                If (lValue And &H80000000) Then
                    RShiftSigned = -1
                Else
                    RShiftSigned = 0
                End If
                Exit Function

                ' A shift of less than zero or more than 31 is undefined
            ElseIf iShiftBits < 0 Or iShiftBits > 31 Then
                Err.Raise(6)
            End If

            ' We get the same result by dividing by the appropriate power of 2 and
            ' rounding in the negative direction
            RShiftSigned = Int(lValue / m_l2Power(iShiftBits))
        End Function

        '*******************************************************************************
        ' RotateLeft (FUNCTION)
        '
        ' PARAMETERS:
        ' (In) - lValue     - Long    - Value to act on
        ' (In) - iShiftBits - Integer - Bits to move by
        '
        ' RETURN VALUE:
        ' Long - Result
        '
        ' DESCRIPTION:
        ' Rotates the bits in a long integer to the left, those bits falling off the
        ' left edge are put back on the right edge
        '*******************************************************************************
        Private Function RotateLeft(ByVal lValue As Integer, ByVal iShiftBits As Short) As Integer
            RotateLeft = LShift(lValue, iShiftBits) Or RShift(lValue, 32 - iShiftBits)
        End Function

        '*******************************************************************************
        ' AddUnsigned (FUNCTION)
        '
        ' PARAMETERS:
        ' (In) - lX - Long - First value
        ' (In) - lY - Long - Second value
        '
        ' RETURN VALUE:
        ' Long - Result
        '
        ' DESCRIPTION:
        ' Adds two potentially large unsigned numbers without overflowing
        '*******************************************************************************
        Private Function AddUnsigned(ByVal lX As Integer, ByVal lY As Integer) As Integer
            Dim lX4 As Long
            Dim lY4 As Long
            Dim lX8 As Long
            Dim lY8 As Long
            Dim lResult As Long


            lX8 = lX And &H80000000
            lY8 = lY And &H80000000
            lX4 = lX And &H40000000
            lY4 = lY And &H40000000
            
            lResult = (lX And &H3FFFFFFF) + (lY And &H3FFFFFFF)

            If lX4 And lY4 Then
                lResult = lResult Xor &H80000000 Xor lX8 Xor lY8
            ElseIf lX4 Or lY4 Then
                If lResult And &H40000000 Then
                    lResult = lResult Xor &HC0000000 Xor lX8 Xor lY8
                Else
                    lResult = lResult Xor &H40000000 Xor lX8 Xor lY8
                End If
            Else
                lResult = lResult Xor lX8 Xor lY8
            End If

            AddUnsigned = lResult
        End Function

        '*******************************************************************************
        ' F (FUNCTION)
        '
        ' DESCRIPTION:
        ' MD5's F function
        '*******************************************************************************
        Private Function F(ByVal x As Integer, ByVal y As Integer, ByVal z As Integer) As Integer
            F = (x And y) Or ((Not x) And z)
        End Function
        '*******************************************************************************
        ' G (FUNCTION)
        '
        ' DESCRIPTION:
        ' MD5's G function
        '*******************************************************************************
        Private Function G(ByVal x As Integer, ByVal y As Integer, ByVal z As Integer) As Integer
            G = (x And z) Or (y And (Not z))
        End Function
        '*******************************************************************************
        ' H (FUNCTION)
        '
        ' DESCRIPTION:
        ' MD5's H function
        '*******************************************************************************
        Private Function H(ByVal x As Integer, ByVal y As Integer, ByVal z As Integer) As Integer
            H = (x Xor y Xor z)
        End Function
        '*******************************************************************************
        ' I (FUNCTION)
        '
        ' DESCRIPTION:
        ' MD5's I function
        '*******************************************************************************
        Private Function I(ByVal x As Integer, ByVal y As Integer, ByVal z As Integer) As Integer
            I = (y Xor (x Or (Not z)))
        End Function
        '*******************************************************************************
        ' FF (SUB)
        '
        ' DESCRIPTION:
        ' MD5's FF procedure
        '*******************************************************************************
        Private Sub FF(ByRef a As Integer, ByVal b As Integer, ByVal c As Integer, ByVal d As Integer, ByVal x As Integer, ByVal s As Integer, ByVal ac As Integer)
            a = AddUnsigned(a, AddUnsigned(AddUnsigned(F(b, c, d), x), ac))
            a = RotateLeft(a, s)
            a = AddUnsigned(a, b)
        End Sub
        '*******************************************************************************
        ' GG (SUB)
        '
        ' DESCRIPTION:
        ' MD5's GG procedure
        '*******************************************************************************
        Private Sub GG(ByRef a As Integer, ByVal b As Integer, ByVal c As Integer, ByVal d As Integer, ByVal x As Integer, ByVal s As Integer, ByVal ac As Integer)
            a = AddUnsigned(a, AddUnsigned(AddUnsigned(G(b, c, d), x), ac))
            a = RotateLeft(a, s)
            a = AddUnsigned(a, b)
        End Sub
        '*******************************************************************************
        ' HH (SUB)
        '
        ' DESCRIPTION:
        ' MD5's HH procedure
        '*******************************************************************************
        Private Sub HH(ByRef a As Integer, ByVal b As Integer, ByVal c As Integer, ByVal d As Integer, ByVal x As Integer, ByVal s As Integer, ByVal ac As Integer)
            a = AddUnsigned(a, AddUnsigned(AddUnsigned(H(b, c, d), x), ac))
            a = RotateLeft(a, s)
            a = AddUnsigned(a, b)
        End Sub
        '*******************************************************************************
        ' II (SUB)
        '
        ' DESCRIPTION:
        ' MD5's II procedure
        '*******************************************************************************
        Private Sub II(ByRef a As Integer, ByVal b As Integer, ByVal c As Integer, ByVal d As Integer, ByVal x As Integer, ByVal s As Integer, ByVal ac As Integer)
            a = AddUnsigned(a, AddUnsigned(AddUnsigned(I(b, c, d), x), ac))
            a = RotateLeft(a, s)
            a = AddUnsigned(a, b)
        End Sub
        '*******************************************************************************
        ' ConvertToWordArray (FUNCTION)
        '
        ' PARAMETERS:
        ' (In/Out) - sMessage - String - String message
        '
        ' RETURN VALUE:
        ' Long() - Converted message as long array
        '
        ' DESCRIPTION:
        ' Takes the string message and puts it in a long array with padding according to
        ' the MD5 rules. Note we are using only the first byte of each character with
        ' the AscB function, this may well mess up in unicode/dbcs situations where you
        ' are comparing what was generated on two different PCs with different
        ' character sets.
        '*******************************************************************************
        Private Function ConvertToWordArray(ByRef sMessage As String) As Integer()
            Dim lMessageLength As Integer
            Dim lNumberOfWords As Integer
            Dim lWordArray() As Integer
            Dim lBytePosition As Integer
            Dim lByteCount As Integer
            Dim lWordCount As Integer
            Dim lChar As Integer

            Const MODULUS_BITS As Integer = 512
            Const CONGRUENT_BITS As Integer = 448

            lMessageLength = Len(sMessage)

            ' Get padded number of words. Message needs to be congruent to 448 bits,
            ' modulo 512 bits. If it is exactly congruent to 448 bits, modulo 512 bits
            ' it must still have another 512 bits added. 512 bits = 64 bytes
            ' (or 16 * 4 byte words), 448 bits = 56 bytes. This means lMessageSize must
            ' be a multiple of 16 (i.e. 16 * 4 (bytes) * 8 (bits))
            lNumberOfWords = (((lMessageLength + ((MODULUS_BITS - CONGRUENT_BITS) \ BITS_TO_A_BYTE)) \ (MODULUS_BITS \ BITS_TO_A_BYTE)) + 1) * (MODULUS_BITS \ BITS_TO_A_WORD)
            ReDim lWordArray(lNumberOfWords - 1)

            ' Combine each block of 4 bytes (ascii code of character) into one long
            ' value and store in the message. The high-order (most significant) bit of
            ' each byte is listed first. However, the low-order (least significant) byte
            ' is given first in each word.
            lBytePosition = 0
            lByteCount = 0
            Do Until lByteCount >= lMessageLength
                ' Each word is 4 bytes
                lWordCount = lByteCount \ BYTES_TO_A_WORD

                ' The bytes are put in the word from the right most edge
                lBytePosition = (lByteCount Mod BYTES_TO_A_WORD) * BITS_TO_A_BYTE
                'UPGRADE_ISSUE: AscB function is not supported. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="367764E5-F3F8-4E43-AC3E-7FE0B5E074E2"'
                '            Strings.AscW()
                lChar = Strings.AscW(Mid(sMessage, lByteCount + 1, 1))
                lWordArray(lWordCount) = lWordArray(lWordCount) Or LShift(lChar, lBytePosition)
                lByteCount = lByteCount + 1
            Loop

            ' Terminate according to MD5 rules with a 1 bit, zeros and the length in
            ' bits stored in the last two words
            lWordCount = lByteCount \ BYTES_TO_A_WORD
            lBytePosition = (lByteCount Mod BYTES_TO_A_WORD) * BITS_TO_A_BYTE

            ' Add a terminating 1 bit, all the rest of the bits to the end of the
            ' word array will default to zero
            lWordArray(lWordCount) = lWordArray(lWordCount) Or LShift(&H80S, lBytePosition)

            ' We put the length of the message in bits into the last two words, to get
            ' the length in bits we need to multiply by 8 (or left shift 3). This left
            ' shifted value is put in the first word. Any bits shifted off the left edge
            ' need to be put in the second word, we can work out which bits by shifting
            ' right the length by 29 bits.
            lWordArray(lNumberOfWords - 2) = LShift(lMessageLength, 3)
            lWordArray(lNumberOfWords - 1) = RShift(lMessageLength, 29)

            'ConvertToWordArray = CopyArray(lWordArray)
            Return lWordArray.Clone
        End Function
        '*******************************************************************************
        ' WordToHex (FUNCTION)
        '
        ' PARAMETERS:
        ' (In) - lValue - Long - Long value to convert
        '
        ' RETURN VALUE:
        ' String - Hex value to return
        '
        ' DESCRIPTION:
        ' Takes a long integer and due to the bytes reverse order it extracts the
        ' individual bytes and converts them to hex appending them for an overall hex
        ' value
        '*******************************************************************************
        Private Function WordToHex(ByVal lValue As Integer) As String
            Dim sAns As String = ""
            Dim lByte As Integer
            Dim lCount As Integer

            For lCount = 0 To 3
                lByte = RShift(lValue, lCount * BITS_TO_A_BYTE) And m_lOnBits(BITS_TO_A_BYTE - 1)
                sAns &= Right("0" & Hex(lByte), 2)
            Next
            Return sAns
        End Function
        '*******************************************************************************
        ' MD5 (FUNCTION)
        '
        ' PARAMETERS:
        ' (In/Out) - sMessage - String - String to be digested
        '
        ' RETURN VALUE:
        ' String - The MD5 digest
        '
        ' DESCRIPTION:
        ' This function takes a string message and generates an MD5 digest for it.
        ' sMessage can be up to the VB string length limit of 2^31 (approx. 2 billion)
        ' characters.
        '
        ' NOTE: Due to the way in which the string is processed the routine assumes a
        ' single byte character set. VB passes unicode (2-byte) character strings, the
        ' ConvertToWordArray function uses on the first byte for each character. This
        ' has been done this way for ease of use, to make the routine truly portable
        ' you could accept a byte array instead, it would then be up to the calling
        ' routine to make sure that the byte array is generated from their string in
        ' a manner consistent with the string type.
        '*******************************************************************************
        Public Function MD5(ByRef sMessage As String) As String
            Dim x() As Integer
            Dim k As Integer
            Dim AA As Integer
            Dim BB As Integer
            Dim CC As Integer
            Dim DD As Integer
            Dim a As Integer
            Dim b As Integer
            Dim c As Integer
            Dim d As Integer

            Const S11 As Integer = 7
            Const S12 As Integer = 12
            Const S13 As Integer = 17
            Const S14 As Integer = 22
            Const S21 As Integer = 5
            Const S22 As Integer = 9
            Const S23 As Integer = 14
            Const S24 As Integer = 20
            Const S31 As Integer = 4
            Const S32 As Integer = 11
            Const S33 As Integer = 16
            Const S34 As Integer = 23
            Const S41 As Integer = 6
            Const S42 As Integer = 10
            Const S43 As Integer = 15
            Const S44 As Integer = 21

            ' Steps 1 and 2.  Append padding bits and length and convert to words
            x = ConvertToWordArray(sMessage)

            ' Step 3.  Initialize
            a = &H67452301
            b = &HEFCDAB89
            c = &H98BADCFE
            d = &H10325476

            ' Step 4.  Process the message in 16-word blocks
            For k = 0 To UBound(x) Step 16
                AA = a
                BB = b
                CC = c
                DD = d

                ' The hex number on the end of each of the following procedure calls is
                ' an element from the 64 element table constructed with
                ' T(i) = Int(4294967296 * Abs(Sin(i))) where i is 1 to 64.
                '
                ' However, for speed we don't want to calculate the value every time.
                FF(a, b, c, d, x(k + 0), S11, &HD76AA478)
                FF(d, a, b, c, x(k + 1), S12, &HE8C7B756)
                FF(c, d, a, b, x(k + 2), S13, &H242070DB)
                FF(b, c, d, a, x(k + 3), S14, &HC1BDCEEE)
                FF(a, b, c, d, x(k + 4), S11, &HF57C0FAF)
                FF(d, a, b, c, x(k + 5), S12, &H4787C62A)
                FF(c, d, a, b, x(k + 6), S13, &HA8304613)
                FF(b, c, d, a, x(k + 7), S14, &HFD469501)
                FF(a, b, c, d, x(k + 8), S11, &H698098D8)
                FF(d, a, b, c, x(k + 9), S12, &H8B44F7AF)
                FF(c, d, a, b, x(k + 10), S13, &HFFFF5BB1)
                FF(b, c, d, a, x(k + 11), S14, &H895CD7BE)
                FF(a, b, c, d, x(k + 12), S11, &H6B901122)
                FF(d, a, b, c, x(k + 13), S12, &HFD987193)
                FF(c, d, a, b, x(k + 14), S13, &HA679438E)
                FF(b, c, d, a, x(k + 15), S14, &H49B40821)

                GG(a, b, c, d, x(k + 1), S21, &HF61E2562)
                GG(d, a, b, c, x(k + 6), S22, &HC040B340)
                GG(c, d, a, b, x(k + 11), S23, &H265E5A51)
                GG(b, c, d, a, x(k + 0), S24, &HE9B6C7AA)
                GG(a, b, c, d, x(k + 5), S21, &HD62F105D)
                GG(d, a, b, c, x(k + 10), S22, &H2441453)
                GG(c, d, a, b, x(k + 15), S23, &HD8A1E681)
                GG(b, c, d, a, x(k + 4), S24, &HE7D3FBC8)
                GG(a, b, c, d, x(k + 9), S21, &H21E1CDE6)
                GG(d, a, b, c, x(k + 14), S22, &HC33707D6)
                GG(c, d, a, b, x(k + 3), S23, &HF4D50D87)
                GG(b, c, d, a, x(k + 8), S24, &H455A14ED)
                GG(a, b, c, d, x(k + 13), S21, &HA9E3E905)
                GG(d, a, b, c, x(k + 2), S22, &HFCEFA3F8)
                GG(c, d, a, b, x(k + 7), S23, &H676F02D9)
                GG(b, c, d, a, x(k + 12), S24, &H8D2A4C8A)

                HH(a, b, c, d, x(k + 5), S31, &HFFFA3942)
                HH(d, a, b, c, x(k + 8), S32, &H8771F681)
                HH(c, d, a, b, x(k + 11), S33, &H6D9D6122)
                HH(b, c, d, a, x(k + 14), S34, &HFDE5380C)
                HH(a, b, c, d, x(k + 1), S31, &HA4BEEA44)
                HH(d, a, b, c, x(k + 4), S32, &H4BDECFA9)
                HH(c, d, a, b, x(k + 7), S33, &HF6BB4B60)
                HH(b, c, d, a, x(k + 10), S34, &HBEBFBC70)
                HH(a, b, c, d, x(k + 13), S31, &H289B7EC6)
                HH(d, a, b, c, x(k + 0), S32, &HEAA127FA)
                HH(c, d, a, b, x(k + 3), S33, &HD4EF3085)
                HH(b, c, d, a, x(k + 6), S34, &H4881D05)
                HH(a, b, c, d, x(k + 9), S31, &HD9D4D039)
                HH(d, a, b, c, x(k + 12), S32, &HE6DB99E5)
                HH(c, d, a, b, x(k + 15), S33, &H1FA27CF8)
                HH(b, c, d, a, x(k + 2), S34, &HC4AC5665)

                II(a, b, c, d, x(k + 0), S41, &HF4292244)
                II(d, a, b, c, x(k + 7), S42, &H432AFF97)
                II(c, d, a, b, x(k + 14), S43, &HAB9423A7)
                II(b, c, d, a, x(k + 5), S44, &HFC93A039)
                II(a, b, c, d, x(k + 12), S41, &H655B59C3)
                II(d, a, b, c, x(k + 3), S42, &H8F0CCC92)
                II(c, d, a, b, x(k + 10), S43, &HFFEFF47D)
                II(b, c, d, a, x(k + 1), S44, &H85845DD1)
                II(a, b, c, d, x(k + 8), S41, &H6FA87E4F)
                II(d, a, b, c, x(k + 15), S42, &HFE2CE6E0)
                II(c, d, a, b, x(k + 6), S43, &HA3014314)
                II(b, c, d, a, x(k + 13), S44, &H4E0811A1)
                II(a, b, c, d, x(k + 4), S41, &HF7537E82)
                II(d, a, b, c, x(k + 11), S42, &HBD3AF235)
                II(c, d, a, b, x(k + 2), S43, &H2AD7D2BB)
                II(b, c, d, a, x(k + 9), S44, &HEB86D391)

                a = AddUnsigned(a, AA)
                b = AddUnsigned(b, BB)
                c = AddUnsigned(c, CC)
                d = AddUnsigned(d, DD)
            Next

            ' Step 5.  Output the 128 bit digest
            MD5 = LCase(WordToHex(a) & WordToHex(b) & WordToHex(c) & WordToHex(d))
        End Function
    End Class
    Public Class CGenericRegistration
        ' 32 Numerics and alphas - we are missing I, O, S and Z not just because
        ' we only want 32 characters but also because I could be mistaken for
        ' the number 1, O for 0, S for 5 and Z for 2.
        Private Const VALID_CHARS As String = "0123456789ABCDEFGHJKLMNPQRTUVWXY"
        Private Const RANDOM_LOWER As Integer = 0
        Private Const RANDOM_UPPER As Integer = 31
        '*******************************************************************************
        ' GenerateKey (FUNCTION)
        '
        ' PARAMETERS:
        ' (In/Out) - sAppChars - String - Application specific characters to be used
        '                                 during the MD5 operation.
        '
        ' RETURN VALUE:
        ' String - The key
        '
        ' DESCRIPTION:
        ' Generates a random key by first selecting 9 random characters from our 32
        ' valid characters, adding our application specific characters, creating an
        ' MD5 digest, and using the digest to select the other 16 characters for
        ' our key.
        '*******************************************************************************
        Public Function GenerateKey(ByRef sAppChars As String) As String
            Dim lChar As Integer
            Dim lCount As Integer
            Dim sInitialChars As String
            Dim oMD5 As CMD5
            Dim sMD5 As String
            Dim sKey As String

            Randomize()

            ' We first generate 9 random characters that are members of VALID_CHARS
            sInitialChars = ""
            For lCount = 1 To 9
                lChar = Int((RANDOM_UPPER - RANDOM_LOWER + 1) * Rnd() + RANDOM_LOWER)
                sInitialChars = sInitialChars & Mid(VALID_CHARS, lChar + 1, 1)
            Next

            ' We now get an MD5 of our initial chars plus out application chars
            ' The application chars should be different for each application to
            ' ensure that a key for one of our applications is not valid on another
            ' of our applications. If hackers know we are using this method for
            ' generating our keys we should ensure that the application characters
            ' are very long to help prevent cracking.
            oMD5 = New CMD5
            sMD5 = oMD5.MD5(sInitialChars & sAppChars)

            oMD5 = Nothing

            ' We now take each byte-pair from the MD5, convert it back to a byte
            ' value from the hex code, do a MOD 32, and then select the appropriate
            ' character from our VALID_CHARS
            sKey = sInitialChars

            For lCount = 1 To 16
                lChar = CInt("&H" & Mid(sMD5, (lCount * 2) - 1, 2)) Mod 32
                sKey = sKey & Mid(VALID_CHARS, lChar + 1, 1)
            Next

            GenerateKey = sKey
        End Function
        '*******************************************************************************
        ' IsKeyOK (FUNCTION)
        '
        ' PARAMETERS:
        ' (In/Out) - sKey      - String - Key to check
        ' (In/Out) - sAppChars - String - Application specific characters used in
        '                                 generating the key.
        '
        ' RETURN VALUE:
        ' Boolean - True if valid
        '
        ' DESCRIPTION:
        ' Takes the key, recalculates the MD5 part and tests for equality.
        '*******************************************************************************
        Public Function IsKeyOK(ByRef sKey As String, ByRef sAppChars As String) As Boolean
            Dim bAns As Boolean = False
            Dim lChar As Integer
            Dim lCount As Integer
            Dim sInitialChars As String
            Dim oMD5 As CMD5
            Dim sMD5 As String
            Dim sTestKey As String

            ' Get the initial 9 characters, which were our random characters
            sInitialChars = Left(sKey, 9)

            ' Recalculate the MD5 digest
            oMD5 = New CMD5
            sMD5 = oMD5.MD5(sInitialChars & sAppChars)

            oMD5 = Nothing

            ' We now take each byte-pair from the MD5, convert it back to a byte
            ' value from the hex code, do a MOD 32, and then select the appropriate
            ' character from our VALID_CHARS
            sTestKey = sInitialChars

            For lCount = 1 To 16
                lChar = CInt("&H" & Mid(sMD5, (lCount * 2) - 1, 2)) Mod 32
                sTestKey = sTestKey & Mid(VALID_CHARS, lChar + 1, 1)
            Next

            ' Check for equality
            bAns = (sTestKey = sKey)

            Return bAns
        End Function
    End Class
    Public Class oEncrypt
        Public Shared Function EncryptMD5(ByVal cleanString As String) As String
            Dim clearBytes As [Byte]()
            clearBytes = New UnicodeEncoding().GetBytes(cleanString)
            Dim hashedBytes As [Byte]() = CType(CryptoConfig.CreateFromName("MD5"), HashAlgorithm).ComputeHash(clearBytes)
            Dim hashedText As String = BitConverter.ToString(hashedBytes)
            Return hashedText
        End Function
        Public Function EncryptSHA(ByVal Data As String) As String
            Dim shaM As New SHA1Managed
            Convert.ToBase64String(shaM.ComputeHash(Encoding.ASCII.GetBytes(Data)))
            Dim eNC_data() As Byte = ASCIIEncoding.ASCII.GetBytes(Data)
            Dim eNC_str As String = Convert.ToBase64String(eNC_data)
            EncryptSHA = eNC_str
        End Function
        Public Function DecryptSHA(ByVal Data As String) As String
            Try
                Dim dEC_data() As Byte = Convert.FromBase64String(Trim(Data))
                Dim dEC_Str As String = ASCIIEncoding.ASCII.GetString(dEC_data)
                DecryptSHA = dEC_Str
            Catch ex As Exception
                Return ex.Message
            End Try
        End Function
        Public Function EncryptURL(ByVal strUrl As String, ByVal strSessionID As String) As String
            Dim strReturn As String = strSessionID & "|" & Trim(strUrl) & "|" & Now.Ticks.ToString
            Return EncryptSHA(Trim(strReturn))

        End Function
        Public Function DecryptURL(ByVal strUrl As String, ByVal strSessionID As String) As String
            Dim pageEncrypt As String
            pageEncrypt = DecryptSHA(strUrl)
            Return pageEncrypt

        End Function
    End Class
    Public Class RegistrationProcess
        Private Const MAXUSEDAYS As Integer = 30
        Private Const INSTALLONCEID_PATH As String = "Software\\Microsoft\\Windows\\CurrentVersion\\Applets"
        Private Const INSTALLONCEID_KEY As String = "WindowsSystemRegMarkerv4"
        Private Const FIELD_REGISTRATION_NAME As String = "SetHistListdt"
        Private Const FIELD_REGISTRATION_KEY As String = "SetHistListtb"
        Private Const FIELD_REGISTRATION_EXPERATION As String = "HistKeyList"
        Private _MYREGVALUE As String
        Public Property RegistrationKeyValue() As String
            Get
                Return "36999"
            End Get
            Set(ByVal value As String)
                _MYREGVALUE = value
            End Set
        End Property
        Private _RegPath As String
        Public Property DefaultRegPath() As String
            Get
                Return "Software\\BurnSoft\\BSMGC"
            End Get
            Set(ByVal value As String)
                _RegPath = value
            End Set
        End Property
#Region " Registration Notes "
        'The Main Part will be put in the startup function of your main form
        'When the application starts up you will need to call the startRegistration Sub
#End Region
        Public Sub StartRegistration(ByVal strRegPath As String, ByRef IsRegistered As Boolean, ByRef DaysLeft As String, ByRef HasExpired As Boolean, ByRef RegisteredTo As String)
            Dim MyRegName As String = ""
            Dim MyregKey As String = ""
            Dim MyExpDate As String = ""
            Call GetRegKeys(strRegPath, MyRegName, MyregKey, MyExpDate)
            If Len(MyExpDate) = 0 Then
                MyExpDate = DateAdd(DateInterval.Day, 30, DateTime.Now)
                SaveExpDate(strRegPath, MyExpDate)
            End If

            Dim CurDate As Date = DateTime.Now
            DaysLeft = DateDiff("d", CurDate, MyExpDate)
            Dim oReg As New CGenericRegistration
            MyregKey = Replace(MyregKey, "-", "")
            IsRegistered = oReg.IsKeyOK(MyregKey, RegistrationKeyValue)
            If TESTEXPIRED Then IsRegistered = False
            If IsRegistered = False Then
                Dim DayDiff As Integer = DateTime.Compare(CurDate, MyExpDate)
                If DayDiff >= 0 Then
                    HasExpired = True
                Else
                    HasExpired = False
                End If
            Else
                HasExpired = False
                RegisteredTo = MyRegName
            End If
            If TESTEXPIRED Then HasExpired = True
        End Sub
        Private Sub GetRegKeys(ByVal strRegPath As String, ByRef RegName As String, ByRef RegKey As String, ByRef ExpDate As String)
            Dim MyReg As RegistryKey
            Dim strValue As String = strRegPath
            Dim oD As New oEncrypt
            MyReg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(strValue, True)
            If MyReg Is Nothing Then
                If InstalledBefore_Exists() = False Then
                    Dim RegName1 As String = ""
                    Dim regKey1 As String = ""
                    Dim ExpDate1 As String = ""
                    Call SaveRegKeys(strRegPath, RegName1, regKey1, ExpDate1)
                    RegName = oD.DecryptSHA(RegName1)
                    RegKey = oD.DecryptSHA(regKey1)
                    ExpDate = oD.DecryptSHA(ExpDate1)
                    Call SetInstalledBefore()
                Else
                    RegName = ""
                    RegKey = ""
                    ExpDate = DateTime.Now
                End If
            Else
                RegName = oD.DecryptSHA(MyReg.GetValue(FIELD_REGISTRATION_NAME, ""))
                RegKey = oD.DecryptSHA(MyReg.GetValue(FIELD_REGISTRATION_KEY, ""))
                ExpDate = oD.DecryptSHA(MyReg.GetValue(FIELD_REGISTRATION_EXPERATION, ""))
            End If
        End Sub
        Public Sub SetRegKeys()
            If InstalledBefore_Exists() = False Then Call SaveRegKeys(DefaultRegPath & "\Settings")
        End Sub
        Private Sub SaveExpDate(ByVal strRegPath As String, ByVal MyExpDate As String)
            Dim MyReg As RegistryKey
            Dim strValue As String = strRegPath
            Dim oE As New oEncrypt
            Dim ExpDate As String
            MyReg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(strValue, True)
            ExpDate = oE.EncryptSHA(MyExpDate)
            If MyReg Is Nothing Then
                MyReg = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(strValue)
                MyReg.SetValue(FIELD_REGISTRATION_EXPERATION, ExpDate)
            Else
                MyReg.SetValue(FIELD_REGISTRATION_EXPERATION, ExpDate)
            End If
            MyReg.Close()
        End Sub
        Private Sub SaveRegKeys(ByVal strRegPath As String, Optional ByRef MyregName As String = "", Optional ByRef MyRegKey As String = "", Optional ByRef ExpDate As String = "")
            Dim MyReg As RegistryKey
            Dim strValue As String = strRegPath
            Dim oE As New oEncrypt
            MyReg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(strValue, True)
            If MyReg Is Nothing Then
                MyReg = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(strValue)
                Dim MyDays As String = CStr(DateAdd("d", MAXUSEDAYS, DateTime.Now))
                ExpDate = oE.EncryptSHA(MyDays)
                MyregName = oE.EncryptSHA(MyregName)
                MyRegKey = oE.EncryptSHA(MyRegKey)

                MyReg.SetValue(FIELD_REGISTRATION_EXPERATION, ExpDate)
                MyReg.SetValue(FIELD_REGISTRATION_KEY, MyRegKey)
                MyReg.SetValue(FIELD_REGISTRATION_NAME, MyregName)
                '---------This is just for the starting of the program----
                MyReg.SetValue("TrackHistoryDays", 30)
                MyReg.SetValue("TrackHistory", False)
                MyReg.SetValue("NumberFormat", "0000")
                MyReg.SetValue("AutoUpdate", False)
                MyReg.SetValue("UseProxy", False)
                '--------------End Start Settings-------------
                MyReg.Close()
            End If
        End Sub
        Public Sub JustSave(ByVal strRegPath As String, ByVal strName As String, ByVal strKey As String)
            Dim MyReg As RegistryKey
            Dim oE As New oEncrypt
            MyReg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(strRegPath, True)
            MyReg.SetValue(FIELD_REGISTRATION_KEY, oE.EncryptSHA(strKey))
            MyReg.SetValue(FIELD_REGISTRATION_NAME, oE.EncryptSHA(strName))
            MyReg.Close()
        End Sub
        Private Sub SetInstalledBefore()
            Dim MyReg As RegistryKey
            Dim oE As New oEncrypt
            MyReg = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(INSTALLONCEID_PATH & "\\" & INSTALLONCEID_KEY)
            MyReg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(INSTALLONCEID_PATH & "\\" & INSTALLONCEID_KEY, True)
            MyReg.SetValue("Default", "1")
            MyReg.Close()
        End Sub
        Public Sub DeleteInstalledBefore()
            On Error Resume Next
            Call Microsoft.Win32.Registry.CurrentUser.DeleteSubKey(INSTALLONCEID_PATH & "\\" & INSTALLONCEID_KEY)
        End Sub

        Public Function InstalledBefore_Exists() As Boolean
            Dim bAns As Boolean = False
            Dim MyReg As RegistryKey
            Dim strValue As String = INSTALLONCEID_PATH & "\\" & INSTALLONCEID_KEY
            Dim MyValue As String
            On Error Resume Next
            Err.Clear()
            MyReg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(strValue, True)
            If MyReg Is Nothing Then
                Call SetInstalledBefore()
                bAns = False
            Else
                MyValue = MyReg.GetValue("Default", "")
                If Len(MyValue) > 0 Or Err.Number = 0 Then
                    bAns = True
                Else
                    bAns = False
                End If
            End If
            Return bAns
        End Function
    End Class
End Namespace
