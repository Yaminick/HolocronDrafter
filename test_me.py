import pytest

@pytest.mark.parametrize('name, left, right', [['foo', 'a', 'a'],
                                               ['bar', 'c', 'c'],
                                               ['baz', 'b', 'b']])
def test_me(name, left, right):
    assert left == right, name

@pytest.mark.parametrize('name, left, right', [['foo', 'x', 'x'],
                                               ['bar', 'y', 'y'],
                                               ['baz', 'z', 'z']])
def test_me_next(name, left, right):
    assert left == right, name

def test_me_later(name, left, right):
    assert left == right, name