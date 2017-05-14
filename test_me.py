import pytest

@pytest.mark.parametrize('name, left, right', [['foo', 'a', 'a'],
                                               ['bar', 'a', 'b'],
                                               ['baz', 'b', 'b']])
def test_me(name, left, right):
    assert left == right, name

@pytest.mark.parametrize('name, left, right', [['foo', 'x', 'x'],
                                               ['bar', 'y', 'y'],
                                               ['baz', 'x', 'z']])
def test_me_next(name, left, right):
    assert left == right, name
