"�R
DDeviceIDLE"IDLE1�����ƠBA�����ƠBQ      �?Y      �?�Unknown
BHostIDLE"IDLE1ffff�/AAffff�/Aa{���o�?i{���o�?�Unknown
�HostResourceApplyAdam"$Adam/Adam/update_2/ResourceApplyAdam(1����]�A9����]�AA����]�AI����]�Aa�n	�f}�?iv��z)W�?�Unknown
�HostMaxPoolGrad"@gradient_tape/sequential_12/max_pooling2d_24/MaxPool/MaxPoolGrad(1ffff&NA9ffff&NAAffff&NAIffff&NAa���b� �?i�K��S�?�Unknown
zHost_FusedConv2D" sequential_12/activation_39/Relu(1����L��@9����L��@A����L��@I����L��@a�jZ;�?i�\3:	��?�Unknown
HostMatMul"+gradient_tape/sequential_12/dense_15/MatMul(1������@9������@A������@I������@a �Y)�0�?i;��|�?�Unknown
�HostConv2DBackpropFilter"Agradient_tape/sequential_12/conv2d_24/Conv2D/Conv2DBackpropFilter(13333��@93333��@A3333��@I3333��@a��0g�P�?i<# [�?�Unknown
�HostReluGrad"2gradient_tape/sequential_12/activation_39/ReluGrad(1����I-�@9����I-�@A����I-�@I����I-�@a�3F�>.�?iSj�^�?�Unknown
�	HostMatMul"-gradient_tape/sequential_12/dense_15/MatMul_1(1    `��@9    `��@A    `��@I    `��@a������?i��e�IE�?�Unknown
{
HostMaxPool"&sequential_12/max_pooling2d_24/MaxPool(1���̌��@9���̌��@A���̌��@I���̌��@a�.5�]�?i^��6��?�Unknown
zHost_FusedMatMul" sequential_12/activation_40/Relu(1    `��@9    `��@A    `��@I    `��@a�u��Zf�?i�+�h{�?�Unknown
�HostBiasAddGrad"9gradient_tape/sequential_12/conv2d_24/BiasAdd/BiasAddGrad(1����L��@9����L��@A����L��@I����L��@ab����n�?iz&z�#��?�Unknown
uHostFlushSummaryWriter"FlushSummaryWriter(13333�L�@93333�L�@A3333�L�@I3333�L�@a���84�x?i��\���?�Unknown�
^HostGatherV2"GatherV2(1fffff��@9fffff��@Afffff��@Ifffff��@a��'�-G?i���{��?�Unknown
�HostResourceApplyAdam""Adam/Adam/update/ResourceApplyAdam(1     �F@9     �F@A     �F@I     �F@a#�k��1?iN/�j���?�Unknown
iHostWriteSummary"WriteSummary(1ffffff<@9ffffff<@Affffff<@Iffffff<@a7"=����>iȃ���?�Unknown�
sHostDataset"Iterator::Model::ParallelMapV2(1     �7@9     �7@A     �7@I     �7@a�_�#�>i��(22��?�Unknown
�HostResourceApplyAdam"$Adam/Adam/update_1/ResourceApplyAdam(1������4@9������4@A������4@I������4@a7�3J���>i�:bY��?�Unknown
xHostSoftmax"#sequential_12/activation_41/Softmax(1�����L4@9�����L4@A�����L4@I�����L4@a���b�>ic�ڠ��?�Unknown
�HostDataset"5Iterator::Model::ParallelMapV2::Zip[1]::ForeverRepeat(1      7@9      7@A������3@I������3@a��uc�v�>iO�����?�Unknown
xHost_FusedMatMul"sequential_12/dense_16/BiasAdd(1������2@9������2@A������2@I������2@am�Lt���>i�T����?�Unknown
�Host#SparseSoftmaxCrossEntropyWithLogits"gsparse_categorical_crossentropy/SparseSoftmaxCrossEntropyWithLogits/SparseSoftmaxCrossEntropyWithLogits(133333�0@933333�0@A33333�0@I33333�0@a���@zv�>i���o���?�Unknown
�HostMatMul"-gradient_tape/sequential_12/dense_16/MatMul_1(1ffffff-@9ffffff-@Affffff-@Iffffff-@a�0�ޱ�>ij�!��?�Unknown
�HostResourceApplyAdam"$Adam/Adam/update_4/ResourceApplyAdam(1������+@9������+@A������+@I������+@a{޶0�>i� �Q��?�Unknown
�HostResourceApplyAdam"$Adam/Adam/update_5/ResourceApplyAdam(1������)@9������)@A������)@I������)@aJ,�}�>i#2o5��?�Unknown
�HostMul"Ugradient_tape/sparse_categorical_crossentropy/SparseSoftmaxCrossEntropyWithLogits/mul(1ffffff)@9ffffff)@Affffff)@Iffffff)@a��a�B��>i��t\M��?�Unknown
�HostResourceApplyAdam"$Adam/Adam/update_3/ResourceApplyAdam(1������(@9������(@A������(@I������(@a����\�>i���d��?�Unknown
�HostDataset"?Iterator::Model::ParallelMapV2::Zip[0]::FlatMap[0]::Concatenate(1ffffff0@9ffffff0@A      (@I      (@az�����>ib�T{��?�Unknown
HostMatMul"+gradient_tape/sequential_12/dense_16/MatMul(1ffffff'@9ffffff'@Affffff'@Iffffff'@a�{z�
�>i���_���?�Unknown
�HostSum"1sparse_categorical_crossentropy/weighted_loss/Sum(1      !@9      !@A      !@I      !@a7i/���>i�7c���?�Unknown
�HostStridedSlice"-sparse_categorical_crossentropy/strided_slice(1������ @9������ @A������ @I������ @ap5E?F�>i�<W���?�Unknown
g HostStridedSlice"strided_slice(1������@9������@A������@I������@a{��fg��>i�����?�Unknown
�!HostReluGrad"2gradient_tape/sequential_12/activation_40/ReluGrad(1      @9      @A      @I      @a�揈�B�>i_��	���?�Unknown
�"HostPack"/sparse_categorical_crossentropy/Reshape_1/shape(1������@9������@A������@I������@a`�ѡ-!�>iH�i����?�Unknown
d#HostDataset"Iterator::Model(1������>@9������>@Affffff@Iffffff@a7"=����>igZ�����?�Unknown
[$HostAddV2"Adam/add(1      @9      @A      @I      @aq��A`�>i�3�*���?�Unknown
e%Host
LogicalAnd"
LogicalAnd(1      @9      @A      @I      @aq��A`�>i[��?�Unknown�
`&HostGatherV2"
GatherV2_1(1������@9������@A������@I������@a����\�>iP	��?�Unknown
Z'HostArgMax"ArgMax(1������@9������@A������@I������@ar Dz�>ir���?�Unknown
v(HostAssignAddVariableOp"AssignAddVariableOp_2(1ffffff@9ffffff@Affffff@Iffffff@a���(��>ia,YS$��?�Unknown
�)HostBiasAddGrad"8gradient_tape/sequential_12/dense_15/BiasAdd/BiasAddGrad(1������@9������@A������@I������@a�^]9�X�>iI�.��?�Unknown
�*HostTile"Bgradient_tape/sparse_categorical_crossentropy/weighted_loss/Tile_1(1������@9������@A������@I������@a�^]9�X�>i�e;�8��?�Unknown
�+HostBiasAddGrad"8gradient_tape/sequential_12/dense_16/BiasAdd/BiasAddGrad(1������@9������@A������@I������@a7�3J���>iي6xB��?�Unknown
V,HostSum"Sum_2(1������@9������@A������@I������@a��uc�v�>i����K��?�Unknown
l-HostIteratorGetNext"IteratorGetNext(1ffffff@9ffffff@Affffff@Iffffff@aDշ|2U�>i��^T��?�Unknown
x.HostDataset"#Iterator::Model::ParallelMapV2::Zip(1����̌F@9����̌F@A������@I������@a�r��F��>i�A=�\��?�Unknown
�/HostDataset"OIterator::Model::ParallelMapV2::Zip[0]::FlatMap[0]::Concatenate[0]::TensorSlice(1������@9������@A������@I������@a�r��F��>i~�`�d��?�Unknown
~0HostAssignAddVariableOp"Adam/Adam/AssignAddVariableOp(1������@9������@A������@I������@aE!�<���>i���l��?�Unknown
v1HostCast"$sparse_categorical_crossentropy/Cast(1������@9������@A������@I������@aE!�<���>i�&��t��?�Unknown
Y2HostPow"Adam/Pow(1      @9      @A      @I      @a�\w^�$�>i�~�N|��?�Unknown
b3HostDivNoNan"div_no_nan_1(1      @9      @A      @I      @a�\w^�$�>i �)؃��?�Unknown
�4HostDataset"AIterator::Model::ParallelMapV2::Zip[1]::ForeverRepeat::FromTensor(1333333@9333333�?A333333@I333333�?a��U��>i G�?���?�Unknown
w5HostReadVariableOp"div_no_nan_1/ReadVariableOp(1      @9      @A      @I      @az�����>i������?�Unknown
t6HostAssignAddVariableOp"AssignAddVariableOp(1333333@9333333@A333333@I333333@a)#����>i�N�]���?�Unknown
v7HostAssignAddVariableOp"AssignAddVariableOp_4(1333333@9333333@A333333@I333333@a)#����>i��EԚ��?�Unknown
]8HostCast"Adam/Cast_1(1ffffff@9ffffff@Affffff@Iffffff@a���(��>i�^����?�Unknown
�9HostCast"bsparse_categorical_crossentropy/ArithmeticOptimizer/ReorderCastLikeAndValuePreserving_int64_Cast_1(1ffffff@9ffffff@Affffff@Iffffff@a���(��>i��,a���?�Unknown
X:HostEqual"Equal(1������@9������@A������@I������@a�^]9�X�>i)wew���?�Unknown
[;HostPow"
Adam/Pow_1(1������@9������@A������@I������@a7�3J���>i�	c]���?�Unknown
�<HostDivNoNan"Lgradient_tape/sparse_categorical_crossentropy/weighted_loss/value/div_no_nan(1������@9������@A������@I������@a7�3J���>iC�`C���?�Unknown
u=HostReadVariableOp"div_no_nan/ReadVariableOp(1      @9      @A      @I      @a�
[
��>i3#����?�Unknown
X>HostCast"Cast_2(1333333@9333333@A333333@I333333@a�7�k�>i�ͪ~���?�Unknown
�?HostCast"?sparse_categorical_crossentropy/weighted_loss/num_elements/Cast(1333333@9333333@A333333@I333333@a�7�k�>i�h2���?�Unknown
`@HostDivNoNan"
div_no_nan(1ffffff@9ffffff@Affffff@Iffffff@aDշ|2U�>i$Y���?�Unknown
�AHostDivNoNan"3sparse_categorical_crossentropy/weighted_loss/value(1ffffff@9ffffff@Affffff@Iffffff@aDշ|2U�>iR�ˮ���?�Unknown
oBHostReadVariableOp"Adam/ReadVariableOp(1������ @9������ @A������ @I������ @aE!�<���>i�N�����?�Unknown
�CHostReadVariableOp"-sequential_12/conv2d_24/Conv2D/ReadVariableOp(1������ @9������ @A������ @I������ @aE!�<���>i��x����?�Unknown
XDHostCast"Cast_4(1       @9       @A       @I       @a�\w^�$�>iS�]���?�Unknown
�EHostReadVariableOp",sequential_12/dense_15/MatMul/ReadVariableOp(1       @9       @A       @I       @a�\w^�$�>i"N�!���?�Unknown
XFHostCast"Cast_3(1�������?9�������?A�������?I�������?a`�ѡ-!�>i\օ���?�Unknown
TGHostMul"Mul(1�������?9�������?A�������?I�������?a`�ѡ-!�>i�������?�Unknown
vHHostAssignAddVariableOp"AssignAddVariableOp_3(1�������?9�������?A�������?I�������?aJ,�}�>i<s�����?�Unknown
vIHostReadVariableOp"Adam/Cast_2/ReadVariableOp(1      �?9      �?A      �?I      �?az�����>i4 ����?�Unknown
vJHostAssignAddVariableOp"AssignAddVariableOp_1(1ffffff�?9ffffff�?Affffff�?Iffffff�?a���(��>i(�Yd���?�Unknown
�KHostReadVariableOp"-sequential_12/dense_15/BiasAdd/ReadVariableOp(1ffffff�?9ffffff�?Affffff�?Iffffff�?a���(��>i9�����?�Unknown
�LHostDataset"/Iterator::Model::ParallelMapV2::Zip[0]::FlatMap(133333�1@933333�1@A�������?I�������?a7�3J���>i��z���?�Unknown
yMHostReadVariableOp"div_no_nan_1/ReadVariableOp_1(1�������?9�������?A�������?I�������?a7�3J���>i�P�����?�Unknown
tNHostReadVariableOp"Adam/Cast/ReadVariableOp(1333333�?9333333�?A333333�?I333333�?a�7�k�>iAU0���?�Unknown
�OHostReadVariableOp",sequential_12/dense_16/MatMul/ReadVariableOp(1�������?9�������?A�������?I�������?a�r��F��>i���B���?�Unknown
VPHostCast"Cast(1      �?9      �?A      �?I      �?a�\w^�$�>i��+%���?�Unknown
�QHostReadVariableOp".sequential_12/conv2d_24/BiasAdd/ReadVariableOp(1      �?9      �?A      �?I      �?a�\w^�$�>i��y���?�Unknown
�RHostReadVariableOp"-sequential_12/dense_16/BiasAdd/ReadVariableOp(1      �?9      �?A      �?I      �?a�\w^�$�>i�q�����?�Unknown
vSHostReadVariableOp"Adam/Cast_3/ReadVariableOp(1�������?9�������?A�������?I�������?a`�ѡ-!�>i�Kڛ���?�Unknown
aTHostIdentity"Identity(1�������?9�������?A�������?I�������?a`�ѡ-!�>i�%�M���?�Unknown�
wUHostReadVariableOp"div_no_nan/ReadVariableOp_1(1�������?9�������?A�������?I�������?a`�ѡ-!�>i�������?�Unknown*�Q
�HostResourceApplyAdam"$Adam/Adam/update_2/ResourceApplyAdam(1����]�A9����]�AA����]�AI����]�AaBk�o�?iBk�o�?�Unknown
�HostMaxPoolGrad"@gradient_tape/sequential_12/max_pooling2d_24/MaxPool/MaxPoolGrad(1ffff&NA9ffff&NAAffff&NAIffff&NAa^�*�5�?i����?�Unknown
zHost_FusedConv2D" sequential_12/activation_39/Relu(1����L��@9����L��@A����L��@I����L��@a��]f�͵?i�;����?�Unknown
HostMatMul"+gradient_tape/sequential_12/dense_15/MatMul(1������@9������@A������@I������@a0k��ݴ?i�3D(�?�Unknown
�HostConv2DBackpropFilter"Agradient_tape/sequential_12/conv2d_24/Conv2D/Conv2DBackpropFilter(13333��@93333��@A3333��@I3333��@a>�d
�G�?i�{�(9q�?�Unknown
�HostReluGrad"2gradient_tape/sequential_12/activation_39/ReluGrad(1����I-�@9����I-�@A����I-�@I����I-�@a^��F�?iV� �C�?�Unknown
�HostMatMul"-gradient_tape/sequential_12/dense_15/MatMul_1(1    `��@9    `��@A    `��@I    `��@ai(�3�?iݽ@�N��?�Unknown
{HostMaxPool"&sequential_12/max_pooling2d_24/MaxPool(1���̌��@9���̌��@A���̌��@I���̌��@a(Dv�S�?i "���?�Unknown
z	Host_FusedMatMul" sequential_12/activation_40/Relu(1    `��@9    `��@A    `��@I    `��@aM&�P��?i��J�d�?�Unknown
�
HostBiasAddGrad"9gradient_tape/sequential_12/conv2d_24/BiasAdd/BiasAddGrad(1����L��@9����L��@A����L��@I����L��@a͂�Mᕐ?i�޶���?�Unknown
uHostFlushSummaryWriter"FlushSummaryWriter(13333�L�@93333�L�@A3333�L�@I3333�L�@a����J�?i��w>��?�Unknown�
^HostGatherV2"GatherV2(1fffff��@9fffff��@Afffff��@Ifffff��@a���D��T?i?������?�Unknown
�HostResourceApplyAdam""Adam/Adam/update/ResourceApplyAdam(1     �F@9     �F@A     �F@I     �F@a�OK,?i9��KD��?�Unknown
iHostWriteSummary"WriteSummary(1ffffff<@9ffffff<@Affffff<@Iffffff<@a�\�$c?ifn�����?�Unknown�
sHostDataset"Iterator::Model::ParallelMapV2(1     �7@9     �7@A     �7@I     �7@a�M��(�?iO�%B���?�Unknown
�HostResourceApplyAdam"$Adam/Adam/update_1/ResourceApplyAdam(1������4@9������4@A������4@I������4@a��7L�?i{�V�:��?�Unknown
xHostSoftmax"#sequential_12/activation_41/Softmax(1�����L4@9�����L4@A�����L4@I�����L4@a����4?iq莚��?�Unknown
�HostDataset"5Iterator::Model::ParallelMapV2::Zip[1]::ForeverRepeat(1      7@9      7@A������3@I������3@ao<DH� ?i�	8���?�Unknown
xHost_FusedMatMul"sequential_12/dense_16/BiasAdd(1������2@9������2@A������2@I������2@a�*Q���>i֫����?�Unknown
�Host#SparseSoftmaxCrossEntropyWithLogits"gsparse_categorical_crossentropy/SparseSoftmaxCrossEntropyWithLogits/SparseSoftmaxCrossEntropyWithLogits(133333�0@933333�0@A33333�0@I33333�0@aRҊPO�>i{�'j:��?�Unknown
�HostMatMul"-gradient_tape/sequential_12/dense_16/MatMul_1(1ffffff-@9ffffff-@Affffff-@Iffffff-@a�Zfl_��>iH��@l��?�Unknown
�HostResourceApplyAdam"$Adam/Adam/update_4/ResourceApplyAdam(1������+@9������+@A������+@I������+@a��-2��>iX�Ja���?�Unknown
�HostResourceApplyAdam"$Adam/Adam/update_5/ResourceApplyAdam(1������)@9������)@A������)@I������)@a�/��Ӳ�>i$������?�Unknown
�HostMul"Ugradient_tape/sparse_categorical_crossentropy/SparseSoftmaxCrossEntropyWithLogits/mul(1ffffff)@9ffffff)@Affffff)@Iffffff)@a6c�Mn��>i|�����?�Unknown
�HostResourceApplyAdam"$Adam/Adam/update_3/ResourceApplyAdam(1������(@9������(@A������(@I������(@a�6V=�>i�(J���?�Unknown
�HostDataset"?Iterator::Model::ParallelMapV2::Zip[0]::FlatMap[0]::Concatenate(1ffffff0@9ffffff0@A      (@I      (@a�̇��W�>i����D��?�Unknown
HostMatMul"+gradient_tape/sequential_12/dense_16/MatMul(1ffffff'@9ffffff'@Affffff'@Iffffff'@a~gľu��>i �:l��?�Unknown
�HostSum"1sparse_categorical_crossentropy/weighted_loss/Sum(1      !@9      !@A      !@I      !@a2������>i�����?�Unknown
�HostStridedSlice"-sparse_categorical_crossentropy/strided_slice(1������ @9������ @A������ @I������ @a�����#�>i�x�/���?�Unknown
gHostStridedSlice"strided_slice(1������@9������@A������@I������@a�"�����>i%�����?�Unknown
�HostReluGrad"2gradient_tape/sequential_12/activation_40/ReluGrad(1      @9      @A      @I      @aÿ)d�m�>iO�=f���?�Unknown
� HostPack"/sparse_categorical_crossentropy/Reshape_1/shape(1������@9������@A������@I������@a���t.i�>i��k����?�Unknown
d!HostDataset"Iterator::Model(1������>@9������>@Affffff@Iffffff@a�\�$c�>i���	��?�Unknown
["HostAddV2"Adam/add(1      @9      @A      @I      @a��ԗ��>i��f�!��?�Unknown
e#Host
LogicalAnd"
LogicalAnd(1      @9      @A      @I      @a��ԗ��>i���X9��?�Unknown�
`$HostGatherV2"
GatherV2_1(1������@9������@A������@I������@a�6V=�>i�<^N��?�Unknown
Z%HostArgMax"ArgMax(1������@9������@A������@I������@aa�DS�>i����a��?�Unknown
v&HostAssignAddVariableOp"AssignAddVariableOp_2(1ffffff@9ffffff@Affffff@Iffffff@a�i)wy��>iX��t��?�Unknown
�'HostBiasAddGrad"8gradient_tape/sequential_12/dense_15/BiasAdd/BiasAddGrad(1������@9������@A������@I������@a&8z��N�>i�/�����?�Unknown
�(HostTile"Bgradient_tape/sparse_categorical_crossentropy/weighted_loss/Tile_1(1������@9������@A������@I������@a&8z��N�>i��K���?�Unknown
�)HostBiasAddGrad"8gradient_tape/sequential_12/dense_16/BiasAdd/BiasAddGrad(1������@9������@A������@I������@a��7L��>i�>����?�Unknown
V*HostSum"Sum_2(1������@9������@A������@I������@ao<DH��>i	������?�Unknown
l+HostIteratorGetNext"IteratorGetNext(1ffffff@9ffffff@Affffff@Iffffff@af�z�1�>i��~"���?�Unknown
x,HostDataset"#Iterator::Model::ParallelMapV2::Zip(1����̌F@9����̌F@A������@I������@an�r���>iԘp���?�Unknown
�-HostDataset"OIterator::Model::ParallelMapV2::Zip[0]::FlatMap[0]::Concatenate[0]::TensorSlice(1������@9������@A������@I������@an�r���>i�Qb����?�Unknown
~.HostAssignAddVariableOp"Adam/Adam/AssignAddVariableOp(1������@9������@A������@I������@at�2�z�>iAk�5���?�Unknown
v/HostCast"$sparse_categorical_crossentropy/Cast(1������@9������@A������@I������@at�2�z�>i��s��?�Unknown
Y0HostPow"Adam/Pow(1      @9      @A      @I      @a{�_��>iP����?�Unknown
b1HostDivNoNan"div_no_nan_1(1      @9      @A      @I      @a{�_��>i x�� ��?�Unknown
�2HostDataset"AIterator::Model::ParallelMapV2::Zip[1]::ForeverRepeat::FromTensor(1333333@9333333�?A333333@I333333�?a��D5�>i��,��?�Unknown
w3HostReadVariableOp"div_no_nan_1/ReadVariableOp(1      @9      @A      @I      @a�̇��W�>i�muE6��?�Unknown
t4HostAssignAddVariableOp"AssignAddVariableOp(1333333@9333333@A333333@I333333@a����>iRy}@��?�Unknown
v5HostAssignAddVariableOp"AssignAddVariableOp_4(1333333@9333333@A333333@I333333@a����>i����I��?�Unknown
]6HostCast"Adam/Cast_1(1ffffff@9ffffff@Affffff@Iffffff@a�i)wy��>iS@�mS��?�Unknown
�7HostCast"bsparse_categorical_crossentropy/ArithmeticOptimizer/ReorderCastLikeAndValuePreserving_int64_Cast_1(1ffffff@9ffffff@Affffff@Iffffff@a�i)wy��>i����\��?�Unknown
X8HostEqual"Equal(1������@9������@A������@I������@a&8z��N�>i�gpf��?�Unknown
[9HostPow"
Adam/Pow_1(1������@9������@A������@I������@a��7L��>i���n��?�Unknown
�:HostDivNoNan"Lgradient_tape/sparse_categorical_crossentropy/weighted_loss/value/div_no_nan(1������@9������@A������@I������@a��7L��>iq���w��?�Unknown
u;HostReadVariableOp"div_no_nan/ReadVariableOp(1      @9      @A      @I      @a-�����>ik�.���?�Unknown
X<HostCast"Cast_2(1333333@9333333@A333333@I333333@a��l�F�>i��Q���?�Unknown
�=HostCast"?sparse_categorical_crossentropy/weighted_loss/num_elements/Cast(1333333@9333333@A333333@I333333@a��l�F�>i�c�t���?�Unknown
`>HostDivNoNan"
div_no_nan(1ffffff@9ffffff@Affffff@Iffffff@af�z�1�>iJ��@���?�Unknown
�?HostDivNoNan"3sparse_categorical_crossentropy/weighted_loss/value(1ffffff@9ffffff@Affffff@Iffffff@af�z�1�>i��>���?�Unknown
o@HostReadVariableOp"Adam/ReadVariableOp(1������ @9������ @A������ @I������ @at�2�z�>iYI�+���?�Unknown
�AHostReadVariableOp"-sequential_12/conv2d_24/Conv2D/ReadVariableOp(1������ @9������ @A������ @I������ @at�2�z�>i	֙J���?�Unknown
XBHostCast"Cast_4(1       @9       @A       @I       @a{�_��>i�|���?�Unknown
�CHostReadVariableOp",sequential_12/dense_15/MatMul/ReadVariableOp(1       @9       @A       @I       @a{�_��>i�O^ڻ��?�Unknown
XDHostCast"Cast_3(1�������?9�������?A�������?I�������?a���t.i�>i������?�Unknown
TEHostMul"Mul(1�������?9�������?A�������?I�������?a���t.i�>i�����?�Unknown
vFHostAssignAddVariableOp"AssignAddVariableOp_3(1�������?9�������?A�������?I�������?a�/��Ӳ�>i���{���?�Unknown
vGHostReadVariableOp"Adam/Cast_2/ReadVariableOp(1      �?9      �?A      �?I      �?a�̇��W�>i'5�����?�Unknown
vHHostAssignAddVariableOp"AssignAddVariableOp_1(1ffffff�?9ffffff�?Affffff�?Iffffff�?a�i)wy��>i�P���?�Unknown
�IHostReadVariableOp"-sequential_12/dense_15/BiasAdd/ReadVariableOp(1ffffff�?9ffffff�?Affffff�?Iffffff�?a�i)wy��>i������?�Unknown
�JHostDataset"/Iterator::Model::ParallelMapV2::Zip[0]::FlatMap(133333�1@933333�1@A�������?I�������?a��7L��>i��#x���?�Unknown
yKHostReadVariableOp"div_no_nan_1/ReadVariableOp_1(1�������?9�������?A�������?I�������?a��7L��>i�w����?�Unknown
tLHostReadVariableOp"Adam/Cast/ReadVariableOp(1333333�?9333333�?A333333�?I333333�?a��l�F�>i�������?�Unknown
�MHostReadVariableOp",sequential_12/dense_16/MatMul/ReadVariableOp(1�������?9�������?A�������?I�������?an�r�ս>i 9�����?�Unknown
VNHostCast"Cast(1      �?9      �?A      �?I      �?a{�_��>ilW����?�Unknown
�OHostReadVariableOp".sequential_12/conv2d_24/BiasAdd/ReadVariableOp(1      �?9      �?A      �?I      �?a{�_��>i�u�t���?�Unknown
�PHostReadVariableOp"-sequential_12/dense_16/BiasAdd/ReadVariableOp(1      �?9      �?A      �?I      �?a{�_��>iD������?�Unknown
vQHostReadVariableOp"Adam/Cast_3/ReadVariableOp(1�������?9�������?A�������?I�������?a���t.i�>i�b�����?�Unknown
aRHostIdentity"Identity(1�������?9�������?A�������?I�������?a���t.i�>il1�����?�Unknown�
wSHostReadVariableOp"div_no_nan/ReadVariableOp_1(1�������?9�������?A�������?I�������?a���t.i�>i      �?�Unknown2GPU